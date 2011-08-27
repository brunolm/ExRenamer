using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ExRenamer.Extenders;
using ExRenamer.IO;
using ExRenamer.Properties;
using System.Drawing;

namespace ExRenamer
{
    public partial class Main : Form
    {
        public List<char> InvalidCharacters
        {
            get
            {
                var invalidCharacters = new List<char>();
                if (isFiles.Checked)
                    invalidCharacters.AddRange(Path.GetInvalidFileNameChars());
                else if (isFolders.Checked)
                    invalidCharacters.AddRange(Path.GetInvalidPathChars());
                else if (isFilesAndFolders.Checked)
                {
                    invalidCharacters.AddRange(Path.GetInvalidFileNameChars());
                    invalidCharacters.AddRange(Path.GetInvalidPathChars());
                }

                return invalidCharacters.Where(c => (int)c != (int)Keys.Back).Where(c => (int)c != 63).ToList();
            }
        }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs ev)
        {
            Location = Settings.Default.StartLocation;

            #region Form Events

            DragEnter += (s, e) =>
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    var dir = (e.Data.GetData(DataFormats.FileDrop) as string[])[0];

                    if (Directory.Exists(dir))
                        e.Effect = DragDropEffects.Move;
                }
            };

            DragDrop += (s, e) =>
            {
                var dir = (e.Data.GetData(DataFormats.FileDrop) as string[])[0];
                folder.Text = dir;
            };

            FormClosing += (s, e) =>
            {
                Settings.Default.StartLocation = Location;
                Settings.Default.Save();
            };

            #endregion

            #region Folder Picker

            folder.Click += (s, e) =>
            {
                if (folderBrowserDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    folder.Text = folderBrowserDialog.SelectedPath;
                }
            };

            #endregion

            #region Tooltip

            prefixLabel.MouseHover += (s, e) =>
            {
                toolTip.Show("Add text on the beginning of the file", prefixLabel);
            };

            suffixLabel.MouseHover += (s, e) =>
            {
                toolTip.Show("Add text on the end of the file", suffixLabel);
            };

            scanLabel.MouseHover += (s, e) =>
            {
                toolTip.Show("Searches the file for regex input", scanLabel);
            };

            scanRepLabel.MouseHover += (s, e) =>
            {
                toolTip.Show("Replace match for text", scanRepLabel);
            };

            numberLabel.MouseHover += (s, e) =>
            {
                toolTip.Show("Replace ? on fields for a number added incrementally", numberLabel);
            };

            numberPadLabel.MouseHover += (s, e) =>
            {
                toolTip.Show("Pad number with 0s", numberPadLabel);
            };

            #endregion

            #region Validations

            KeyPressEventHandler validateInput = (s, e) =>
            {
                e.Handled = InvalidCharacters.Any(x => x == e.KeyChar);
            };

            prefix.KeyPress += validateInput;
            suffix.KeyPress += validateInput;
            scanRep.KeyPress += validateInput;

            #endregion

            preview.Click += (s, e) =>
            {
                Renamer(true);
            };

            rename.Click += (s, e) =>
            {
                if (MessageBox.Show(this, "Are you sure?", "Confirmation", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    Renamer();
            };
        }

        public void Renamer(bool preview = false)
        {
            outputGrid.Rows.Clear();

            string[] entries = GetEntries();

            long successCount = 0;
            var dirCounter = new Dictionary<string, long>();
            entries.ForEach<string>((e) =>
            {
                if (FileUtility.IsHidden(e)) return;

                var info = new DirectoryInfo(e);
                var finfo = new FileInfo(e);

                var newName = Regex.Replace(info.Name, String.Format("[.]{0}$", info.Extension.Replace(".", String.Empty)), String.Empty);
                newName = Regex.Replace(newName, scan.Text, scanRep.Text, (scanMatch.Checked ? RegexOptions.None : RegexOptions.IgnoreCase) | RegexOptions.Compiled);

                if (isTitleCase.Checked)
                    newName = newName.ToTitleCase();

                long c = (long)number.Value;
                if (dirCounter.ContainsKey(finfo.DirectoryName))
                    c = dirCounter[finfo.DirectoryName];
                else
                    dirCounter.Add(finfo.DirectoryName, c);

                newName = String.Format("{0}{1}", prefix.Text.Replace("?", c.ToString().PadLeft((int)numberPad.Value, '0')), newName);
                newName = String.Format("{1}{0}", suffix.Text.Replace("?", c.ToString().PadLeft((int)numberPad.Value, '0')), newName);

                dirCounter[finfo.DirectoryName] = ++c;

                newName = String.Format("{0}{1}", newName, (isLowercase.Checked ? info.Extension.ToLower() : info.Extension));

                var newEntry = Path.Combine(finfo.DirectoryName, newName);

                bool moved = (newName != info.Extension);
                if (!preview)
                {
                    try
                    {
                        if (newName == info.Extension) throw new ArgumentException("Invalid file name");
                        if (!FileUtility.IsDir(e))
                            File.Move(e, newEntry);
                        else
                            Directory.Move(e, newEntry);

                        moved = true;
                        ++successCount;
                    }
                    catch (Exception)
                    {
                        moved = false;
                    }
                }

                var r = new DataGridViewRow();
                r.Cells.Add(new DataGridViewTextBoxCell() { Value = newEntry });
                r.Cells.Add(new DataGridViewCheckBoxCell() { Value = moved });
                outputGrid.Rows.Add(r);
            });

            if (!preview)
                MessageBox.Show(this,
                    String.Format("Renamed: {1}{0}Errors: {2}", Environment.NewLine, successCount, successCount - entries.LongLength),
                    "Completed");
        }

        public string[] GetEntries()
        {
            string[] entries = null;

            if (isFiles.Checked)
            {
                entries = GetFiles();
            }
            else if (isFolders.Checked)
            {
                entries = GetFolders().OrderByDescending(p => p).ToArray();
            }
            else if (isFilesAndFolders.Checked)
            {
                var l = new List<string>();
                l.AddRange(GetFiles());
                l.AddRange(GetFolders().OrderByDescending(p => p).ToArray());
                entries = l.ToArray();
            }

            return entries;
        }

        public string[] GetFolders()
        {
            if (!Directory.Exists(folder.Text)) return null;

            return Directory.GetDirectories(folder.Text, "*", (isRecursive.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
        }

        public string[] GetFiles()
        {
            if (!Directory.Exists(folder.Text)) return null;

            return Directory.GetFiles(folder.Text, searchPattern.Text, (isRecursive.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
        }
    }
}

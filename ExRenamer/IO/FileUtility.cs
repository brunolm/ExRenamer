using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ExRenamer.IO
{
    public static class FileUtility
    {
        public static bool HasAttribute(string path, FileAttributes att)
        {
            return (File.GetAttributes(path) & att) == att;
        }

        public static bool IsDir(string path)
        {
            return HasAttribute(path, FileAttributes.Directory);
        }

        public static bool IsHidden(string path)
        {
            return HasAttribute(path, FileAttributes.Hidden);
        }
    }
}

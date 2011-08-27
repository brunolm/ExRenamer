using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ExRenamer.Extenders
{
    public static class IEnumerableExtender
    {
        public static void ForEach<T>(this IEnumerable<T> els, Action<T> a)
        {
            if (els == null) return;

            foreach (T e in els)
            {
                a(e);
            }
        }

        public static void ForEach(this IEnumerable els, Action a)
        {
            if (els == null) return;

            foreach (var e in els)
            {
                a();
            }
        }
    }
}

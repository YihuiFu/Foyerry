using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foyerry.Tools.String
{
    public static class StringExtensions
    {
        public static string GetItem(this string source, int itemIndex, string separator = ",")
        {
            if (source == null) return string.Empty;
            var items = source.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries);
            return itemIndex > items.Length ? string.Empty : items[itemIndex];
        }
    }
}

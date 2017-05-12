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
            if (string.IsNullOrEmpty(source)) return string.Empty;
            var items = source.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries);
            return itemIndex > items.Length
                ? string.Empty
                : items[itemIndex];
        }

        public static string Ellipsis(this string source, int length, int ellipsisLength)
        {
            if (string.IsNullOrEmpty(source)) return string.Empty;
            return source.Length <= length
                ? source
                : source.Substring(0, length - ellipsisLength).PadRight(length, '.');
        }
    }
}

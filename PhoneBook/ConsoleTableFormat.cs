using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PhoneBook
{
    public class ConsoleTableFormat
    {
        private const int TableWidth = 80;
        public static void PrintSeparatorLine()
        {
            Console.WriteLine(new String('-',TableWidth));
        }
        public static void PrintRow(params string[] columns)
        {
            int columnWidth=(TableWidth-columns.Length)/columns.Length;
            const string seed = "|";
            string row = columns.Aggregate(seed, (seperator, columnText) => seperator  + GetCenterAllignedText(columnText, columnWidth) + seed);
            Console.WriteLine(row);
        }

        private static string GetCenterAllignedText(string columnText, int columnWidth)
        {
            columnText = columnText.Length > columnWidth ? columnText.Substring(0, columnWidth - 3) + "..." : columnText;
            return string.IsNullOrEmpty(columnText)
            ? new string(' ', columnWidth)
                : columnText.PadRight(columnWidth - ((columnWidth - columnText.Length) / 2)).PadLeft(columnWidth);
        }
    }
}

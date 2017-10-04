using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordinalResult = string.Compare("apple", "Apple", StringComparison.Ordinal);
            int ordinalIgnoreCaseResult = string.Compare("apple", "Apple", StringComparison.OrdinalIgnoreCase);
            
            //Console.WriteLine($"Ordinal Compare : {ordinalResult}");
            //Console.WriteLine($"OrdinalIgnoreCase Compare : {ordinalIgnoreCaseResult}");

            DisplayComparision("apple", "Apple", StringComparison.OrdinalIgnoreCase);
            DisplayComparision("apple", "Apple", StringComparison.Ordinal);

        }

        private static void DisplayComparision(string s1, string s2, StringComparison comparison)
        {
            int result = string.Compare(s1, s2, comparison);
            Console.WriteLine($"{s1} {GetCompareSymbol(result)} {s2} ({result},{comparison})");
        }

        private static string GetCompareSymbol(int result)
        {
            if (result == 0)
                return "==";
            if (result > 0)
                return ">";
            else
                return "<";
        }
    }
}

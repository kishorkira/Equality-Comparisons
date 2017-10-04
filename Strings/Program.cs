﻿using System;
using System.Threading;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Current culture : {Thread.CurrentThread.CurrentCulture}");

            int ordinalResult = string.Compare("apple", "Apple", StringComparison.Ordinal);
            int ordinalIgnoreCaseResult = string.Compare("apple", "Apple", StringComparison.OrdinalIgnoreCase);
            //string s1 = "apple";
            //string s2 = "Apple";
            //U+00DF is eszett
            //string s1 = "Stra\u00dfe";
            //string s2 = "Strasse";
            //a-umlaut - \u00e4
            //umlaut - \0306
            string s1 = "erkl\u00e4ren";
            string s2 = "erkla\u0308ren";
            DisplayAllComparision(s1, s2);

        }

        private static void DisplayAllComparision(string s1, string s2)
        {
            Console.WriteLine();
            DisplayComparision(s1, s2, StringComparison.Ordinal);
            DisplayComparision(s1, s2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine();
            DisplayComparision(s1, s2, StringComparison.CurrentCulture);
            DisplayComparision(s1, s2, StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine();
            DisplayComparision(s1, s2, StringComparison.InvariantCulture);
            DisplayComparision(s1, s2, StringComparison.InvariantCultureIgnoreCase);

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

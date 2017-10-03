using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "string";
            string s2 = string.Copy(s1);
            Object s3 = "object";
            Object s4 = string.Copy((string)s3);

            Console.WriteLine($"ReferenceEqual : {ReferenceEquals(s1,s2)}");
            Console.WriteLine($"Method : {s1.Equals(s2)}");
            Console.WriteLine($"Operator : {s1 == s2}");
            Console.WriteLine($"StaticMethod : {object.Equals(s1,s2)}");

            Console.WriteLine($"ReferenceEqual : {ReferenceEquals(s3, s4)}");
            Console.WriteLine($"Method : {s3.Equals(s4)}");
            Console.WriteLine($"Operator : {s3 == s4}");
            Console.WriteLine($"StaticMethod : {object.Equals(s3, s4)}");

        }
    }
}

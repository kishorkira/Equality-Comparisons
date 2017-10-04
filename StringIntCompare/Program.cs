using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIntCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            string apple = "apple";
            string pear = "pear";

            Console.WriteLine(apple.CompareTo(apple));
            Console.WriteLine(apple.CompareTo(pear));
            Console.WriteLine(pear.CompareTo(apple));

            DisplayOrder(apple, apple);
            DisplayOrder(apple, pear);
            DisplayOrder(pear, apple);


        }

        private static void DisplayOrder<T>(T x,T y) where T : IComparable<T>
        {
            int result = x.CompareTo(y);
            if(result == 0)
                Console.WriteLine($"{x,10} = {y}");
            if(result > 0)
                Console.WriteLine($"{x,10} > {y}");
            if(result < 0)
                Console.WriteLine($"{x,10} < {y}");

        }
    }
}

using System;

namespace StringIntCompare
{
    class Program
    {
        static void Main(string[] args)
        {

            CalorieCount cal300 = new CalorieCount(300f);
            CalorieCount cal400 = new CalorieCount(400f);

            DisplayOrder(cal300, cal300);
            DisplayOrder(cal300, cal400);
            DisplayOrder(cal400, cal300);

            if (cal300 < cal400)
                Console.WriteLine("cal300 < cal400");
            //string apple = "apple";
            //string pear = "pear";

            //Console.WriteLine(apple.CompareTo(apple));
            //Console.WriteLine(apple.CompareTo(pear));
            //Console.WriteLine(pear.CompareTo(apple));

            //DisplayOrder(apple, apple);
            //DisplayOrder(apple, pear);
            //DisplayOrder(pear, apple);

            //DisplayOrder(3, 3);
            //DisplayOrder(3, 4);
            //DisplayOrder(4, 3);

            //if(3.CompareTo(4) < 0)
            //    Console.WriteLine("3 < 4");

            //if (3 < 4)
            //    Console.WriteLine("3 < 4");

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

using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Food apple = new Food("Apple");
            Food apple2 = new Food("Apple");

            Food chocolate = new Food("Chocolate");
            Console.WriteLine(apple.Equals(chocolate));
            Console.WriteLine(apple.Equals(apple2));
            Console.WriteLine(apple == apple2);

            Console.WriteLine(Equals(apple, apple2));
            Console.WriteLine(object.Equals(apple,apple2));
            Console.WriteLine(ReferenceEquals(apple, apple2));



        }
    }
}

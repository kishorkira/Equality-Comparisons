using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparerAndEqualityComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Food[] list = 
                {   new Food("Orange",FoodGroup.Fruit),
                    new Food("Banana",FoodGroup.Fruit),
                    new Food("Pear",FoodGroup.Fruit),
                    new Food("Apple",FoodGroup.Fruit)
            };
            Array.Sort(list,FoodNameComparer.Instance);

            foreach(var item in list)
                Console.WriteLine(item);
        }
    }
}

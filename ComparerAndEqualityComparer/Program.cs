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
            Food[] list1 = 
                {  
                    new Food("Apple",FoodGroup.Fruit),
                    new Food("Pear",FoodGroup.Fruit),
                    new CookedFood("Apple",FoodGroup.Fruit,"Baked")
            };
            Food[] list2 =
                {
                    new CookedFood("Apple",FoodGroup.Fruit,"Baked"),
                    new Food("Pear",FoodGroup.Fruit),
                    new Food("Apple",FoodGroup.Fruit)
            };
            SortAndShowList(list1);
            Console.WriteLine();
            SortAndShowList(list2);

        }

        private static void SortAndShowList(Food[] list)
        {
            Array.Sort(list, FoodNameComparer.Instance);
            foreach(var item in list)
                Console.WriteLine(item);
        }
    }
}

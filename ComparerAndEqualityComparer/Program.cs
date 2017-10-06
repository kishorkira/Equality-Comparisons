using System;
using System.Collections.Generic;

namespace ComparerAndEqualityComparer
{
    class Program
    {
        static void Main(string[] args)
        {

            var foodItems = new HashSet<FoodItem>(FoodItemEqualityComparer.Instance)
            {
                new FoodItem("Apple",FoodGroup.Fruit),
                new FoodItem("Pear",FoodGroup.Fruit),
                new FoodItem("pineapple",FoodGroup.Fruit),
                new FoodItem("Apple",FoodGroup.Fruit)

            };

            foreach(var food in foodItems)
                Console.WriteLine(food);
            
            //Food[] list1 = 
            //    {  
            //        new Food("Apple",FoodGroup.Fruit),
            //        new Food("Pear",FoodGroup.Fruit),
            //        new CookedFood("Apple",FoodGroup.Fruit,"Baked")
            //};
            //Food[] list2 =
            //    {
            //        new CookedFood("Apple",FoodGroup.Fruit,"Baked"),
            //        new Food("Pear",FoodGroup.Fruit),
            //        new Food("Apple",FoodGroup.Fruit)
            //};
            //SortAndShowList(list1);
            //Console.WriteLine();
            //SortAndShowList(list2);

        }

        private static void SortAndShowList(Food[] list)
        {
            Array.Sort(list, FoodNameComparer.Instance);
            foreach(var item in list)
                Console.WriteLine(item);
        }
    }
}

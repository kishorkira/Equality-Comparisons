using System;

namespace RefTypeEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            Food apple1 = new Food("Apple", FoodGroup.Fruit);
            Food apple2 = new Food("Apple", FoodGroup.Fruit);

            CookedFood stewedApple = new CookedFood("Apple", FoodGroup.Fruit, "Stewed");
            CookedFood bakedApple = new CookedFood("Apple", FoodGroup.Fruit, "Baked");


            DisplayWhetherEqual(apple1, bakedApple);
            DisplayWhetherEqual(apple1, stewedApple);
            DisplayWhetherEqual(bakedApple, stewedApple);

            DisplayWhetherEqual(apple1, apple2);

        }
        static void DisplayWhetherEqual(Food food1, Food food2)
        {
            if(food1 == food2)
                Console.WriteLine($"{food1,12} == {food2}");
            else
                Console.WriteLine($"{food1,12} != {food2}");

        }
    }
}

using System.Collections.Generic;

namespace ComparerAndEqualityComparer
{
    class FoodItemEqualityComparer : EqualityComparer<FoodItem>
    {
        private static FoodItemEqualityComparer _instance = new FoodItemEqualityComparer();
        public static FoodItemEqualityComparer Instance { get => _instance; }

        private FoodItemEqualityComparer() { }

        public override bool Equals(FoodItem x, FoodItem y)
        {
            return x.Name.ToUpperInvariant() == y.Name.ToUpperInvariant()
                      &&
                      x.FoodGroup == y.FoodGroup; 
        }

        public override int GetHashCode(FoodItem obj)
        {
            return obj.Name.ToUpperInvariant().GetHashCode() ^
                     obj.FoodGroup.GetHashCode();
        }
    }
}

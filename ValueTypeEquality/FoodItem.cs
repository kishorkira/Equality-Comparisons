using System;

namespace ValueTypeEquality
{
    public enum FoodGroup { Meat, Fruit, Vegetables, Sweet}

    public struct FoodItem : IEquatable<FoodItem>
    {
        private readonly string _name;
        private readonly FoodGroup _foodGroup;
        public string Name { get => _name; }
        public FoodGroup FoodGroup { get => _foodGroup; }

        public FoodItem(string name, FoodGroup foodGroup)
        {
            this._name = name;
            this._foodGroup = foodGroup;
        }
        public override string ToString()
        {
            return this._name;
        }
        public override bool Equals(object obj)
        {
            if (obj is FoodItem)
                return Equals((FoodItem)obj);
            else
                return false;
        }

        public bool Equals(FoodItem other)
        {
            return this._name == other._name 
                   && 
                   this._foodGroup == other._foodGroup;
        }
        public static bool operator ==(FoodItem lhs, FoodItem rhs)
        {
            return lhs.Equals(rhs);
        }
        public static bool operator !=(FoodItem lhs, FoodItem rhs)
        {
            return !lhs.Equals(rhs);
        }
        public override int GetHashCode()
        {
            return this._name.GetHashCode() ^ this._foodGroup.GetHashCode();
        }
    }
}

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

        public bool Equals(FoodItem other)
        {
            return this._name == other._name 
                   && 
                   this._foodGroup == other._foodGroup;
        }
    }
}

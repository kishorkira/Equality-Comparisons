namespace RefTypeEquality
{
    public enum FoodGroup { Meat, Fruit, Vegetables, Sweet }
    public class Food
    {
        private readonly string _name;
        private readonly FoodGroup _foodGroup;
        public string Name { get => _name; }
        public FoodGroup FoodGroup { get => _foodGroup; }

        public Food(string name, FoodGroup foodGroup)
        {
            this._name = name;
            this._foodGroup = foodGroup;
        }
        public override string ToString()
        {
            return this._name;
        }
    }
}

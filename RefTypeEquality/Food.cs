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
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Food rhs = obj as Food;
            return this._name == rhs._name && this._foodGroup == rhs._foodGroup;
        }
        public override int GetHashCode()
        {
            return this._name.GetHashCode() ^ this._foodGroup.GetHashCode();
        }
        public static bool operator ==(Food x , Food y)
        {
            return object.Equals(x, y);
        }
        public static bool operator !=(Food x, Food y)
        {
            return !object.Equals(x, y);
        }
    }
}

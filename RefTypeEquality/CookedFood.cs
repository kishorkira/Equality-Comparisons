namespace RefTypeEquality
{
    public sealed class CookedFood: Food
    {
        private string _cookingMethod;       

        public string CookingMethod { get => _cookingMethod; }

        public CookedFood(string name, FoodGroup foodGroup,string cookingMethod) : base(name, foodGroup)
        {
            this._cookingMethod = cookingMethod;
        }

        public override string ToString()
        {
            return $"{Name} : {_cookingMethod}";
        }

        public override bool Equals(object obj)
        {
            if (!base.Equals(obj)) { return false; }

            CookedFood rhs = obj as CookedFood;
            return this._cookingMethod == rhs._cookingMethod;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this._cookingMethod.GetHashCode();
        }

        public static bool operator ==(CookedFood x, CookedFood y)
        {
            return object.Equals(x, y);
        }

        public static bool operator !=(CookedFood x, CookedFood y)
        {
            return !object.Equals(x, y);
        }
    }
}

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
            return $"{_cookingMethod} {Name}";
        }
    }
}

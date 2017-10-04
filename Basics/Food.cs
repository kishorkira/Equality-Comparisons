namespace Basics
{
    public class Food
    {
        string _name;
        public string Name { get => _name; }

        public Food(string name)
        {
           this._name = name;
        }
        public override string ToString()
        {
            return _name;
        }
        
    }
}

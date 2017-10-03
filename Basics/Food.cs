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
        //public override bool Equals(object obj)
        //{
        //    if (obj == null)
        //        return false;
        //    if (!(obj is Food))
        //        return false;
        //    return this._name == ((Food)obj)._name;
        //}
        //public override int GetHashCode()
        //{
        //    return this._name.GetHashCode();
        //}
    }
}

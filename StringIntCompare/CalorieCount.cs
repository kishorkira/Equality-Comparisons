using System;

namespace StringIntCompare
{
    class CalorieCount : IComparable<CalorieCount>
    {
        private float _calories;
        public float Calories { get => _calories; }

        public CalorieCount(float cal)
            => _calories = cal;

        public override string ToString()
            => _calories + " cal";

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (!(obj is CalorieCount))
                return false;
            return this._calories == ((CalorieCount)obj)._calories;
            
        }

        public override int GetHashCode()
        {
            return this._calories.GetHashCode();
        }

        public int CompareTo(CalorieCount other)
            => this._calories.CompareTo(other._calories);


        public static bool operator <(CalorieCount x, CalorieCount y)
            => x._calories < y._calories;

        public static bool operator >(CalorieCount x, CalorieCount y)
           => x._calories > y._calories;

        public static bool operator <=(CalorieCount x, CalorieCount y)
           => x._calories <= y._calories;

        public static bool operator >=(CalorieCount x, CalorieCount y)
           => x._calories >= y._calories;

        public static bool operator ==(CalorieCount x, CalorieCount y)
           => x._calories == y._calories;

        public static bool operator !=(CalorieCount x, CalorieCount y)
           => x._calories != y._calories;
    }
}

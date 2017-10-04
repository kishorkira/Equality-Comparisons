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
    }
}

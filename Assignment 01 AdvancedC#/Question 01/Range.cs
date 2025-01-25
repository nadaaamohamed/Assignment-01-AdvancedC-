using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_AdvancedC_.Question_01
{
    internal class Range<T> where T :  IComparable<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }
        public Range(T min, T max)
        {
            Min = min; Max = max;
        }
        
        public bool IsInRange(T value)
        {
            //value <= Max && value >= Min
            return value.CompareTo(Max) <= 0 && value.CompareTo(Min) >= 0;

        }

        public double Length()
        {
            //Max -Min
            return Convert.ToDouble(Max) - Convert.ToDouble(Min);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_AdvancedC_.Question_04
{
    internal  class FixedSizeList<T> where T : IComparable<T>
    {
        public  int[]? arr { get; set; }
        public  int CurrentIndex { get; set; }


        public FixedSizeList(int Capacity )
        {

            if (Capacity <= 0) Console.WriteLine("Capacity must be greater than 0");
            arr = new int [Capacity];
            CurrentIndex = 0;  
        }

       public void Add(int value)
        {
            if ( CurrentIndex>= arr.Length)
            {
                Console.WriteLine("The list is full");
                return;
            }
            arr[CurrentIndex] = value;
            CurrentIndex++;
        }

        public void GetValue(int index)
        {
            if (index < 0 || index >= arr.Length) Console.WriteLine("Index out of range");
            else
            {
                Console.WriteLine(arr[index]);
            }



        }
    }
}

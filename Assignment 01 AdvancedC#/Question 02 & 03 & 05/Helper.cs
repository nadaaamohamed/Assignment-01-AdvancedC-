using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_AdvancedC_.Question_02
{
    internal static class Helper<T> where T : IComparable<T>
    {
        public static void Reverse(T[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) < 0)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }

            }
        }


        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;

        }

        public static void EvenNumbers(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)

                if (Convert.ToInt32(arr[i]) % 2 == 0)

                    Console.WriteLine(arr[i]);

        }

        public static int findfirstnonrepeatedchar(string str)
        {
            int[] charCount = new int[256];
            for (int i = 0; i < str.Length; i++)
            {
                charCount[str[i]]++;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (charCount[str[i]] == 1)
                {
                    return i;
                }
            }
            return -1;


        }
    }
}


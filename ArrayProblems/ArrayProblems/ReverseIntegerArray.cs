using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    internal static class ReverseIntegerArray
    {
        public static void Reverse()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int i = 0, j = arr.Length - 1, temp = 0;
            while(i != j)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++; j--;
            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}

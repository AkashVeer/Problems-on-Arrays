using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    internal static class KthMinElement
    {
        public static void MinElement()
        {
            int[] arr = { 10, 20, 30, 40, 35 };
            MergeSortArray.Merge(arr);
            int k = 2;
            Console.WriteLine();
            Console.WriteLine(arr[arr.Length - k]);
        }
    }
}

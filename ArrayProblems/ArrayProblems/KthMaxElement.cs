using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    internal static class KthMaxElement
    {
        public static void MaxElement()
        {
            int[] arr = { 10, 20, 30, 40, 35 };
            MergeSortArray.Merge(arr);
            int k = 4;
            Console.WriteLine();
            Console.WriteLine(arr[k - 1]);
        }
    }
}

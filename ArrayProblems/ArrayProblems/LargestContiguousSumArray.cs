using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    internal static class LargestContiguousSumArray
    {
        public static void LargestSum()
        {
            int[] arr = { 1, 2, 4, -1, -6, 1, 2 };
            int max = int.MinValue;
            int max_so_far = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                max_so_far = max_so_far + arr[i];

                if (max < max_so_far)
                    max = max_so_far;
                if (max_so_far < 0)
                    max_so_far = 0;
            }

            Console.WriteLine(max);
        }
    }
}

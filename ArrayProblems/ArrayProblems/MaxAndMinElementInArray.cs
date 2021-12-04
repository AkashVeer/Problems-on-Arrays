using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    internal static class MaxAndMinElementInArray
    {
        public static void MaxAndMin()
        {
            int[] arr = { -1, 2, 3, 4, 5, 100, 7, -5 };
            int min = int.MaxValue, max = int.MinValue;
            foreach (var item in arr)
            {
                if (item < min)
                    min = item;
                if (item > max)
                    max = item;
            }
            Console.WriteLine("Min value: " + min + " and Max value: " + max);
        }
    }
}

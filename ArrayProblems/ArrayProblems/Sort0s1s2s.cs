using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    internal static class Sort0s1s2s
    {
        public static void SortArray()
        {
            int[] arr = { 1, 2, 1, 1, 0, 2, 0, 0, 1 };
            int c0 = 0, c1 = 0, c2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    c0++;
                else if (arr[i] == 1)
                    c1++;
                else
                    c2++;
            }

            int m = 0;
            while(c0 > 0)
            {
                arr[m] = 0;
                c0--;
                m++;
            }
            while (c1 > 0)
            {
                arr[m] = 1;
                c1--;
                m++;
            }
            while (c2 > 0)
            {
                arr[m] = 2;
                c2--;
                m++;
            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

        }
    }
}

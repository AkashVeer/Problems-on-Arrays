using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    internal static class MergeSortArray
    {
        public static void Merge(int[] arr = null)
        {
            if(arr == null)
            {
                arr = new int[] { 4, 5, 2, 7, 10, 8 };
            }
            
            Sort(arr, 0, arr.Length - 1);

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

        }

        public static void Sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int mid = l + (r - l) / 2;

                Sort(arr, l, mid);
                Sort(arr, mid + 1, r);

                MergeSort(arr, l, mid, r);
            }
        }

        public static void MergeSort(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            int i, j;

            int[] Left = new int[n1];
            int[] Right = new int[n2];

            for (i = 0; i < Left.Length; i++)
            {
                Left[i] = arr[l + i];
            }
            for (j = 0; j < Right.Length; j++)
            {
                Right[j] = arr[m + 1 + j];
            }

            i = 0; j = 0;
            int k = l;

            while (i < n1 && j < n2)
            {
                if (Left[i] <= Right[j])
                {
                    arr[k] = Left[i];
                    i++;
                }
                else
                {
                    arr[k] = Right[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = Left[i];
                i++; k++;
            }
            while (j < n2)
            {
                arr[k] = Right[j];
                j++; k++;
            }

        }
    }
}

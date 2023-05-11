using Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.ConcreteStrategies
{
    public class QuickSortHoare: ISortStrategy
    {
        public override void Sort(int[] toSort)
        {
            SortHoare(toSort, 0, toSort.Length - 1);
        }

        private static void SortHoare(int[] arr, int start, int end)
        {
            if (start >= end) return;

            var pivIndex = PartitionHoare(arr, start, end);
            SortHoare(arr, start, pivIndex);
            SortHoare(arr, pivIndex + 1, end);
        }

        private static int PartitionHoare(int[] arr, int start, int end)
        {
            var pivot = arr[(start + end) / 2];
            var i = start - 1;
            var j = end + 1;

            while (true)
            {
                do
                {
                    j--;
                } while (arr[j] > pivot);

                do
                {
                    i++;
                } while (arr[i] < pivot);

                if (i >= j)
                {
                    return j;
                }

                Swap(ref arr[i], ref arr[j]);
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }
    }
}

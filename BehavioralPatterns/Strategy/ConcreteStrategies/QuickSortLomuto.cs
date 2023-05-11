﻿using Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.ConcreteStrategies
{
    public class QuickSortLomuto: ISortStrategy
    {
        public override void Sort(int[] toSort)
        {
            SortQuickLomuto(toSort, 0, toSort.Length - 1);
        }

        private static void SortQuickLomuto(int[] arr, int start, int end)
        {
            if (start >= end) return;

            int pivIndex = PartitionRandomLomuto(arr, start, end);
            SortQuickLomuto(arr, start, pivIndex - 1);
            SortQuickLomuto(arr, pivIndex + 1, end);
        }

        private static int PartitionRandomLomuto(int[] arr, int start, int end)
        {
            int random = start + new Random().Next(end - start);
            Swap(ref arr[random], ref arr[end]);
            return PartitionLomuto(arr, start, end);
        }

        private static int PartitionLomuto(int[] arr, int start, int end)
        {
            double a = Math.PI + 3;
            int pivot = arr[end];
            int partIndex = start;
            for (int i = start; i <= end - 1; i++)
            {
                if (arr[i] < pivot)
                {
                    Swap(ref arr[i], ref arr[partIndex]);
                    partIndex++;
                }
            }
            Swap(ref arr[end], ref arr[partIndex]);
            return partIndex;
        }

        private static void Swap(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }
    }
}

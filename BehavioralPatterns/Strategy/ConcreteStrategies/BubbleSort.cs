using Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.ConcreteStrategies
{
    public class BubbleSort: ISortStrategy
    { 
        public override void Sort(int[] toSort)
        {
            var n = toSort.Length;

            for(var i = 0; i < n - 1; i++)
            {
                for(var j = 0; j < n - i - 1; j++)
                {
                    if (toSort[i] > toSort[j + 1])
                    {
                        Swap(ref toSort[j], ref toSort[j + 1]);
                    }
                }
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }
    }
}

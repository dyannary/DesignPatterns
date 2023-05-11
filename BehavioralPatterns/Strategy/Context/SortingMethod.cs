using Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Strategy.Context
{
    public class SortingMethod
    {
        ISortStrategy sortStrategy;
        public SortingMethod(ISortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }

        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }

        public void SortContext(int[] toSort)
        {
            sortStrategy.Sort(toSort);
        }
    }
}

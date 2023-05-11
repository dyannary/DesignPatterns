using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy
{
    public abstract class ISortStrategy
    {
        public abstract void Sort(int[] toSort);
    }
}

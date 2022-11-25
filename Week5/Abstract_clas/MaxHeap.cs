using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_clas
{
    public class MaxHeap:Heap
    {
        public override int Extact()
        {
            var max =_sortedList.Last();
            _sortedList.Remove(max);
            return max;
        }
    }
}

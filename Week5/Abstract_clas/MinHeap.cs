using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_clas
{
    public class MinHeap:Heap
    {
        public override int Extact()
        {
            var min=_sortedList.First();
            _sortedList.Remove(min);
            return min;
        }
    }
}

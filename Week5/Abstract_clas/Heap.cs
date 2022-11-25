using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_clas
{
    public abstract class Heap
    {
        protected SortedSet<int> _sortedList;

        public Heap()
        {
            _sortedList = new SortedSet<int>();
        }

        public abstract int Extact();

        public void Insert(int item)
        {
            _sortedList.Add(item);
        }

    }
}

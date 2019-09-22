using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class SortedList
    {
        private List<string> _list = new List<string>();
        private SortStrategy _sortstrategy;

        public void SetSortStategy(SortStrategy sortStrategy)
        {
            this._sortstrategy = sortStrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortstrategy.Sort(_list);

            foreach(string name in _list)
            {
                Console.WriteLine("   " + name);
            }

            Console.WriteLine();
        }


    }
}

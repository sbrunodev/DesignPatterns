using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _aggregate;
        private int _current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this._aggregate = aggregate;
        }

        public override object CurrentItem()
        {
            return this._aggregate[_current];
        }

        public override object First()
        {
            return this._aggregate[0];
        }

        public override bool IsDone()
        {
            return _current >= _aggregate.Count;
        }

        public override object Next()
        {
            object ret = null;
            if (_current < _aggregate.Count - 1)
                ret = _aggregate[++_current];

            return ret;
        }
    }
}

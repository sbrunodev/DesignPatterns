using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public abstract class Visitor
    {
        public abstract void VisitConcreteElementA(concreteElementA concreteElementA);
        public abstract void VisitConcreteElementB(concreteElementB concreteElementB);
    }
}

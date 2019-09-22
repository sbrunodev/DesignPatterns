using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class ConcreteVisitor1 : Visitor
    {
        public override void VisitConcreteElementA(concreteElementA concreteElementA)
        {
            Console.WriteLine("{0} visitado por {1}",concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void VisitConcreteElementB(concreteElementB concreteElementB)
        {
            Console.WriteLine("{0} visitado por {1}", concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
}

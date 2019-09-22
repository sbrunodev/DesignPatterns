using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ObjectStruture
    {
        private List<Element> _elementos = new List<Element>();

        public void Anexar(Element elemento)
        {
            this._elementos.Add(elemento);
        }

        public void Desanexar(Element elemento)
        {
            this._elementos.Remove(elemento);
        }

        public void Accept(Visitor visitor)
        {
            foreach (Element item in _elementos)
            {
                item.Aceept(visitor);
            }
        }
    }
}

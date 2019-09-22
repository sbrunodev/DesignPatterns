using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "Online";

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            o.State = "Off";
            c.Memento = o.CreateMemento();
            o.State = "Online";

            o.setMemento(c.Memento);

            Console.ReadKey();
        }
    }
}

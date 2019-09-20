using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver();
            Command command = new ConcreceteCommand(receiver);
            Invoker invoker = new Invoker();

            invoker.setCommand(command);
            invoker.ExecuteCommand();

            Console.ReadKey();
        }
    }
}

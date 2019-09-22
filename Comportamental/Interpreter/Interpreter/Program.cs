using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string romano = "MCMXXVIII";

            Contexto contexto = new Contexto(romano);

            List<Expressao> lista = new List<Expressao>();
            lista.Add(new MilharesExpressao());
            lista.Add(new CentenasExpressao());
            lista.Add(new DezenasExpressao());
            lista.Add(new UnidadeExpressao());

            foreach (var exp in lista)
            {
                exp.Interpretador(contexto);
            }

            Console.WriteLine("{0} = {1}", romano, contexto.Output);

            Console.ReadKey();
        }
    }
}

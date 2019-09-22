using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public abstract class Expressao
    {
        public abstract string Um();
        public abstract string Quatro();
        public abstract string Cinco();
        public abstract string Nove();
        public abstract int Multiplicador();

        public void Interpretador(Contexto contexto)
        {
            if (contexto.Input.Length == 0)
                return;

            if (contexto.Input.StartsWith(Nove()))
            {
                contexto.Output += (9 * Multiplicador());
                contexto.Input = contexto.Input.Substring(2);
            }
            else
                if (contexto.Input.StartsWith(Quatro()))
            {
                contexto.Output += (4 * Multiplicador());
                contexto.Input = contexto.Input.Substring(2);
            }
            else
                if (contexto.Input.StartsWith(Cinco()))
            {
                contexto.Output += (5 * Multiplicador());
                contexto.Input = contexto.Input.Substring(2);
            }
            else
                if (contexto.Input.StartsWith(Um()))
            {
                contexto.Output += (1 * Multiplicador());
                contexto.Input = contexto.Input.Substring(2);
            }


            while (contexto.Input.StartsWith(Um()))
            {
                contexto.Output += (1* Multiplicador());
                contexto.Input = contexto.Input.Substring(1) ;
            }
        }
    }
}

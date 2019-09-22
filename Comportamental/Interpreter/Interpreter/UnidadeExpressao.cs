using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class UnidadeExpressao : Expressao
    {
        public override string Cinco()
        {
            return "V";
        }

        public override int Multiplicador()
        {
            return 1;
        }

        public override string Nove()
        {
            return "IX";
        }

        public override string Quatro()
        {
            return "IV";
        }

        public override string Um()
        {
            return "I";
        }
    }
}

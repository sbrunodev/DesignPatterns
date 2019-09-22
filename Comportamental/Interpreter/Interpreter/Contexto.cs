using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class Contexto
    {
        public string Input { get; set; }
        public int Output { get; set; }

        public Contexto(string input)
        {
            this.Input = input;
        }
    }
}

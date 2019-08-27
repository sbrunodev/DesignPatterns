using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Culinaria : ICanal
    {
        public string Canal()
        {
            return "Sintonizado no canal de culinária";
        }

        public string Status()
        {
            return "Você está assistindo - Receita de Bolo de Laranja";
        }
    }
}

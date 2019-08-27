using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Documentario : ICanal
    {
        public string Canal()
        {
            return "Sintonizado no canal de documentarios";
        }

        public string Status()
        {
            return "Você está assistindo - A Origem de tudo";
        }
    }
}

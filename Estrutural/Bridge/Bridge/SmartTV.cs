using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class SmartTV
    {
        // Aqui temos pontes (Bridg). No program chama essa Interface e passamos para ela o objeto.
        public ICanal canal_atual { get; set; }

        public void ExibeCanalSintonizado()
        {
            if (canal_atual != null)
                Console.WriteLine(canal_atual.Canal());
            else
                Console.WriteLine("Por favor, selecione um canal!");
        }

        public void PlayTv()
        {
            if (canal_atual != null)
                Console.WriteLine(canal_atual.Status());
            else
                Console.WriteLine("Por favor, selecione um canal para assistir algo!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class Fabrica_Flyweight
    {
        private Dictionary<string, Tartaruga> listaDeTartaruga = new Dictionary<string, Tartaruga>();

        public Tartaruga GetTartaruga(string cor)
        {
            Tartaruga t = null;

            if (listaDeTartaruga.ContainsKey(cor))
            {
                t = listaDeTartaruga[cor];
            }
            else
            {
                switch (cor)
                {
                    case "Azul": t = new Azul(); break;
                    case "Verde": t = new Verde(); break;
                    case "Vermelha": t = new Vermelha(); break;
                    case "Laranja": t = new Laranja(); break;
                }

                listaDeTartaruga.Add(cor, t);
            }

            return t;
        }
    }
}

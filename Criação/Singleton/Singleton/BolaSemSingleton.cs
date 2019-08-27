using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class BolaSemSingleton
    {
        public BolaSemSingleton()
        {
            Console.WriteLine("Bola em jogo");
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }

    }
}

using System;

namespace Singleton
{
    public sealed class Singleton
    {
        // Quando você coloca que uma classe é sealed quer dizer que ela não pode ser herdada.
        private static Singleton instancia = null;
        
        public static Singleton getInstancia
        {
            get
            {
                if (instancia == null)
                {
                    Console.WriteLine("Bola em jogo");
                    instancia = new Singleton();
                }
                return instancia;
            }
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}

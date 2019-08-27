using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton: Dessa forma a gente garante que só vai ter uma bola em jogo.
            // Instancia única.

            //BolaSemSingleton jogador_1 = new BolaSemSingleton();
            Singleton jogador_1 = Singleton.getInstancia;
            jogador_1.Mensagem("Jogador 1: A bola está comigo no meio de campo.");

            //BolaSemSingleton jogador_2 = new BolaSemSingleton();
            Singleton jogador_2 = Singleton.getInstancia;
            jogador_2.Mensagem("Jogador 2: Recebeu a bola.");

            //BolaSemSingleton jogador_3 = new BolaSemSingleton();
            Singleton jogador_3 = Singleton.getInstancia;
            jogador_3.Mensagem("Jogador 3: Recebeu o lançamento na linha de fundo");

            Console.ReadKey();
        }
    }
}

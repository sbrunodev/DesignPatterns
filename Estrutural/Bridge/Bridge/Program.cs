using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartTV minhaTV = new SmartTV();

            Console.WriteLine("Seleciom um canal: ");
            Console.WriteLine("1 - Filmes \n 2 - Documentarios \n 3 - Culinarias ");

            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.KeyChar)
            {
                case '1': minhaTV.canal_atual = new Filme();break;
                case '2': minhaTV.canal_atual = new Documentario(); break;
                case '3': minhaTV.canal_atual = new Culinaria(); break;
            }

            Console.WriteLine();


            minhaTV.ExibeCanalSintonizado();
            minhaTV.PlayTv();


            Console.ReadKey();
        }
    }
}

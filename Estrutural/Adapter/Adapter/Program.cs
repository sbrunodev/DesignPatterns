using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            TanqueInimigo tx2019 = new TanqueInimigo();
            RoboInimigo R2D2 = new RoboInimigo();

            IAtaqueInimigo roboAdapter = new RoboInimigoAdapter(R2D2);

            Console.WriteLine(" ===== ROBO ===== ");
            R2D2.ReagirContraHumano("Bruno");
            R2D2.AndarParaFrente();
            R2D2.EsmagarComMaos();

            Console.WriteLine(" ===== TANQUE ===== ");
            tx2019.Pilotar("Bruno");
            tx2019.Movimenta();
            tx2019.ArmaFogo();

            Console.WriteLine(" ===== ROBO ADAPTADO ===== ");
            roboAdapter.Pilotar("Bruno");
            roboAdapter.Movimenta();
            roboAdapter.ArmaFogo();

            Console.ReadKey();
        }
    }
}

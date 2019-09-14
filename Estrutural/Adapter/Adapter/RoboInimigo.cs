using System;

namespace Adapter
{
    // Ele é o objeto que será adaptado
    public class RoboInimigo
    {
        Random gerador = new Random();

        public void EsmagarComMaos()
        {
            int DanoAtaque = this.gerador.Next(10) + 1;
            Console.WriteLine("Inicimigo causou " + DanoAtaque + " de dano com o ataque esmagar com as maos");
        }

        public void AndarParaFrente()
        {
            int movimento = this.gerador.Next(5) + 1;
            Console.WriteLine("O robo inimigo andou " + movimento + " passos para frente");
        }

        public void ReagirContraHumano(string piloto)
        {
            Console.WriteLine("O Robo inimigo vai contra" + piloto);
        }
    }
}

﻿using System;

namespace Adapter
{
    public class TanqueInimigo : IAtaqueInimigo
    {
        Random gerador = new Random();

        public void ArmaFogo()
        {
            int danoAtaque = this.gerador.Next(10) + 1;
            Console.WriteLine("Tanque inimigo fez " + danoAtaque + " de dano");
        }

        public void Movimenta()
        {
            int danoAtaque = this.gerador.Next(5) + 1;
            Console.WriteLine("Tanque inimigo andou " + danoAtaque + " passos");
        }

        public void Pilotar(string piloto)
        {
            Console.WriteLine(piloto + " está no comando do tanque");
        }
    }
}

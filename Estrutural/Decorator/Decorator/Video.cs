using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Video : ItemBiblioteca
    {
        public string Diretor { get; set; }
        public string Titulo { get; set; }
        public int MinutosDuracao { get; set; }

        public Video(string Diretor, string Titulo, int MinutosDuracao, int NumeroCopias)
        {
            this.Diretor = Diretor;
            this.Titulo = Titulo;
            this.MinutosDuracao = MinutosDuracao;
            this.NumeroCopias = NumeroCopias;
        }

        public override void Exibe()
        {
            Console.WriteLine("\nVideo-----");
            Console.WriteLine(" Diretor: " + Diretor);
            Console.WriteLine(" Titulo:" + Titulo);
            Console.WriteLine(" Duração: " + this.NumeroCopias);
            Console.WriteLine(" # Cópias: " + NumeroCopias);
        }
    }
}

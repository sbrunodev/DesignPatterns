using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Livro : ItemBiblioteca
    {
        public string Autor { get; set; }
        public string Titulo { get; set; }

        public Livro(string Autor, string Titulo, int NumeroCopias)
        {
            this.Autor = Autor;
            this.Titulo = "";
            this.NumeroCopias = NumeroCopias;
        }

        public override void Exibe()
        {
            Console.WriteLine("\nLivro-----");
            Console.WriteLine(" Autor: " + Autor);
            Console.WriteLine(" Titulo:" + Titulo);
            Console.WriteLine(" # Cópias: " + NumeroCopias);
        }
    }
}

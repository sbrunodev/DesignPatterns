using System;

namespace Decorator
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Criar um Livro
            Livro livro = new Livro("Bruno", "Programação em C#", 10);

            // Criar um Livro
            Video video = new Video("Bruno", "Video Aulas de React-Native", 50, 10);

            // Vou emprestar um video e mostrar na tela
            Console.WriteLine("\nEmprestando um video: ");

            Emprestado emprestando = new Emprestado(video);
            emprestando.EmprestarItem("Carlos");
            emprestando.EmprestarItem("Maria");

            emprestando.Exibe();

            emprestando.DevolverItem("Carlos");

            emprestando.Exibe();


            Console.ReadKey();

        }
    }
}

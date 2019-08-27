using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioPermanente funcPermanente = new FuncionarioPermanente();
            funcPermanente.Nome = "João";
            funcPermanente.Idade = 30;
            funcPermanente.Tipo = "Permanente";

            FuncionarioPermanente funcPermanenteClone = (FuncionarioPermanente)funcPermanente.Clone();
            funcPermanenteClone.Nome = "Carlos";
            funcPermanenteClone.Idade = 40;

            Console.WriteLine("Detalhes do Funcionário Permanente: ");
            Console.WriteLine("Nome: {0}; Idade: {1}; Tipo: {2}", funcPermanente.Nome, funcPermanente.Idade, funcPermanente.Tipo);
            Console.WriteLine("Detalhes do Funcionário Permanente (Clonado): ");
            Console.WriteLine("Nome: {0}; Idade: {1}; Tipo: {2}", funcPermanenteClone.Nome, funcPermanenteClone.Idade, funcPermanenteClone.Tipo);

            Console.ReadKey();

        }
    }
}

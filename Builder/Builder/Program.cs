using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria o Fabricante  
            Fabricante fabricante = new Fabricante();

            //Permite qua a classe Builder esteja pronta
            ICelular celularBuilder = null;

            //Agora vamos criar um celular Android
            celularBuilder = new IPhoneBuilder();
            fabricante.Construtor(celularBuilder);

            Console.Write("Fabricado o celular: "+celularBuilder.Celular.Nome);

            Console.ReadLine();
        }
    }
}

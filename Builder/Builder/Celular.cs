using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Celular
    {
        string nomeCelular;

        public Celular(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get; set; }
        public string tela { get; set; }
        public string bateria { get; set; }
        public string sistema { get; set; }
        public string camera { get; set; }
    }
}

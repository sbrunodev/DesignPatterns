using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ObservadorConcreto : Observador
    {
        private string _nome;
        private string _estadoobservador;
        private AssuntoConcreto _assunto;

        public ObservadorConcreto(AssuntoConcreto assunto, string nome)
        {
            this._assunto = assunto;
            this._nome = nome;
        }

        public override void Update()
        {
            this._estadoobservador = this._assunto.EstadoAssunto;
            Console.WriteLine("Observador {0}' seu novo estado é: {1}", this._nome, this._estadoobservador);
        }

        public AssuntoConcreto Assunto { get; set; }
       


    }
}

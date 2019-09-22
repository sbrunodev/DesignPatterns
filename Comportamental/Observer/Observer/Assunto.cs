using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class Assunto
    {
        private List<Observador> _observadores = new List<Observador>();

        public void Anexar(Observador observador)
        {
            this._observadores.Add(observador);
        }

        public void Desanexar(Observador observador)
        {
            this._observadores.Remove(observador);
        }

        public void Notificar()
        {
            foreach (Observador item in _observadores)
            {
                item.Update();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class ItemBiblioteca
    {
        public int NumeroCopias { get; set; }

        public abstract void Exibe();
    }
}

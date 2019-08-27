using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    interface IPersonagem
    {
        // A interface obriga as classes que herdarem a mesma implementar os seus métodos.
        void Escolhido();
    }
}

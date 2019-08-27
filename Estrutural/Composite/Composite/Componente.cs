﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public abstract class Componente
    {
        protected string nome;

        public Componente(string nome)
        {
            this.nome = nome;
        }

        public abstract void Adicionar(Componente c);
        public abstract void Remover(Componente c);
        public abstract void Mostrar(int profundidade);
        
    }
}

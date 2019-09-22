﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.cs
{
    public class Originator
    {
        private string _state;

        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine("State = "+_state);
            }
        }

        public Memento CreateMemento()
        {
            return new Memento(_state);
        }

        public void setMemento(Memento memento)
        {
            Console.WriteLine("Restaurando o Estado...");
            State = memento.State;
        }
    }
}

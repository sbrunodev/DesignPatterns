﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.state = new ConcreteStateB();
        }
    }
}

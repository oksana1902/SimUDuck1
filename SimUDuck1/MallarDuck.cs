﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck1
{
    public class MallarDuck : Duck
    {
        public override string display()
        {
            return "display" + this.GetType();
        }
    }
}

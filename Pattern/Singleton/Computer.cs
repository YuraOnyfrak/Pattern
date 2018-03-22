﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Computer
    {
        public OS OS { get; set; }

        public void Launch(string name)
        {
           OS = OS.getInstance(name);
        }
    }
}

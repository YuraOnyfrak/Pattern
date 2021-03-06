﻿using Strategy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Implement
{
    class Context
    {
        public IStrategy ContextStrategy { get; set; }

        public Context(IStrategy strategy)
        {
            ContextStrategy = strategy;
        }

        public void ExecuteAlgorithm()
        {
            ContextStrategy.Algorithm();
        }
    }
}

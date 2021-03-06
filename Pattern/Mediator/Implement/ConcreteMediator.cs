﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorPattern.Abstract;

namespace MediatorPattern.Implement
{
    class ConcreteMediator : Mediator
    {
        public Farmer Farmer { get; set; }

        public Cannery Cannery { get; set; }

        public Shop Shop { get; set; }

        public override void Send(string messege, Colleague colleague)
        {
            if (colleague == Farmer)
            {
                Cannery.MakeKetchup(messege);
            }
            else if (colleague== Cannery)
            {
                Shop.SellKetchup(messege);
            }
        }
    }

   
}

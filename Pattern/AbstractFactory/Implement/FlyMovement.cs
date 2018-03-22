using AbstractFactory.Abstract;
using System;

namespace AbstractFactory.Implement
{
    internal class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Летим");
        }
    }
}
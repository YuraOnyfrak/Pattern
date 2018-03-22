using AbstractFactory.Abstract;
using System;

namespace AbstractFactory.Implement
{
    internal class Run : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Бежим");
        }
    }
}
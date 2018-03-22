using AbstractFactory.Abstract;
using System;

namespace AbstractFactory.Implement
{
    internal class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Бьем мечом");
        }
    }
}
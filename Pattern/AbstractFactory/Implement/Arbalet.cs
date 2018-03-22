using AbstractFactory.Abstract;
using System;

namespace AbstractFactory.Implement
{
    internal class Arbalet : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Стреляем из арбалета");
        }
    }
}
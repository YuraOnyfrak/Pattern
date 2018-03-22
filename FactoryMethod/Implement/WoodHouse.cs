using FactoryMethod.Abstract;
using System;

namespace FactoryMethod.Implement
{
    internal class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Деревянный дом построен");
        }
    }
}
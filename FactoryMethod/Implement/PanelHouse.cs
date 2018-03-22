using FactoryMethod.Abstract;
using System;

namespace FactoryMethod.Implement
{
    internal class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Панельный дом построен");
        }
    }
}
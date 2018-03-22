using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomentoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            hero.Shoot();
            GameHistory gameHistory = new GameHistory();

            gameHistory.History.Push(hero.SaveState());
            hero.Shoot();

            hero.RestoreState(gameHistory.History.Pop());
            hero.Shoot();

            Console.Read();
        }
    }
}

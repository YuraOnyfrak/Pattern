using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomentoPattern
{
    class GameHistory
    {
        public Stack<HeroMomento> History{ get;  private set; }

        public GameHistory()
        {
            History = new Stack<HeroMomento>();
        }
    }
}

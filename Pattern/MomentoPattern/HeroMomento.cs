namespace MomentoPattern
{
    public class HeroMomento
    {
        public int Patrons { get; private set; }

        public int Lives { get; private set; }

        public HeroMomento(int patrons, int lives)
        {
            Patrons = patrons;
            Lives = lives;
        }
    }
}
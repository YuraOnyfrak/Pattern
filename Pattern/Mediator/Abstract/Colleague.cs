namespace MediatorPattern.Abstract
{
    abstract class Colleague
    {
        protected Mediator Mediator { get; set; }

        public Colleague(Mediator mediator)
        {
            this.Mediator = mediator;
        }

    }
}
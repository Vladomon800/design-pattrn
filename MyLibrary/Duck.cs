namespace MyLibrary
{
    public abstract class Duck
    {
        protected IQuackBehavior quackBehavior;
        protected IFlyBehavior flyBehavior;
        public string Display()
        {
            return "Display" + this.GetType() + " " + this.flyBehavior.fly() + " " + this.quackBehavior.quack();
        }
        public string Swim()
        {
            return "Буль буль буль" + " " + this.GetType();

        }
        public string fly()
        {
            return flyBehavior.fly();
        }
        public string quack()
        {
            return quackBehavior.quack();
        }
        public IFlyBehavior FFlyBehavior
        {
            set
            {
                flyBehavior = value;
            }
        }

        public IQuackBehavior QQuackBehavior
        {
            set
            {
                quackBehavior = value;
            }
        }
    }
}
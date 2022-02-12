using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace MyConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck[] ducks = new Duck[]
            {
                new MallardDuck(),
                new RedHeadDuck(),
                new RubberDuck(),
                new DecoyDuck()
            };
            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck.Swim());
                Console.WriteLine(duck.Display());
                if (duck is IFlyable)
                {
                    Console.WriteLine((duck as IFlyable).fly());
                }
                if (duck is IQuackable)
                {
                    Console.WriteLine((duck as IQuackable).quack());
                }
            }
            Console.ReadKey();
        }
    }
}
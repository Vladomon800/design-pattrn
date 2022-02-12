using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            RedHeadDuck readheadDuck = new RedHeadDuck();
            Duck mallardDuck = new MallardDuck();
            DecoyDuck decoyDuck = new DecoyDuck();
            RubberDuck rubberDuck = new RubberDuck();

            Duck[] ducks = new Duck[] { readheadDuck, mallardDuck, decoyDuck, rubberDuck };

            foreach (var x in ducks)
            {
                Console.WriteLine(x.Swim());
                Console.WriteLine(x.Display());
                Console.WriteLine(x.quack());
                Console.WriteLine(x.fly());
            }

            mallardDuck.QQuackBehavior = new Squeak();
            Console.WriteLine(mallardDuck.Display());
            Console.WriteLine(mallardDuck.quack());

            mallardDuck.FFlyBehavior = new FlyNoWay();
            Console.WriteLine(mallardDuck.Display());
            Console.WriteLine(mallardDuck.fly());

            Console.ReadKey();
        }
    }
}
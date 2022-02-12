using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class MallardDuck : Duck, IFlyable, IQuackable
    {
        public override string Display()
        {
            return "Display" + this.GetType();
        }
        public string quack()
        {
            return "Quack" + this.GetType();
        }
        public string fly()
        {
            return "Fly" + this.GetType();
        }
    }
}
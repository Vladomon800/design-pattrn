using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class MuteQuack : IQuackBehavior
    {
        public string quack()
        {
            return "..." + this.GetType();
        }
    }
}
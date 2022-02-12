using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class FlyWithWings : IFlyBehavior
    {
        public string fly()
        {
            return "Хлоп хлоп хлоп" + this.GetType();
        }
    }
}
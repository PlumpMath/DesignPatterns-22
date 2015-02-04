using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Classes
{
    class DecoratorA : IComponent
    {
        IComponent component;

        public DecoratorA(IComponent c) {
            component = c;        
        }

        public string Operation()
        {
            string s = component.Operation();
            s += "and listening to Class FM ";

            return s;
        }
    }
}

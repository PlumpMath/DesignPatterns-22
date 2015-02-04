using Decorator.Classes;
using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Display(string s, IComponent c)
        {
            Console.WriteLine(s + c.Operation());

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Decorator Pattern\n");

            IComponent component = new Component();

            Display("1. basic component:", component);
            Display("2. A - decorated:", new DecoratorA(component));
            Display("3. B - decorated:", new DecoratorB(component));
            Display("4. B-A - decorated:", new DecoratorB(new DecoratorA(component)));

            DecoratorB b = new DecoratorB(new Component());
            Display("5. A-B-deorated:", new DecoratorA(b));
            Console.WriteLine("\t\t\t" + b.addedState + b.AddedBehavior());

            Console.ReadLine();
        }
    }
}

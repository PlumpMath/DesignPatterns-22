using Adapter.Classes;
using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Adaptee first = new Adaptee();
            Console.Write("Before the new standard\nPrecise reading:");
            Console.WriteLine(first.SpecificRequest(5, 3));

            ITarget second = new AdapterClass();
            Console.WriteLine("\nMoving to the new standard");
            Console.WriteLine(second.Request(5));

            Console.ReadLine();
        }
    }
}

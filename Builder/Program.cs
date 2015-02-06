using Builder.Classes;
using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            IBuilder b1 = new Builder1();
            IBuilder b2 = new Builder2();

            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Display();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Display();

            Console.ReadLine();
        }
    }
}

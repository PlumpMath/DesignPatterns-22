using Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy.Classes;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proxy Pattern\n");
            ISubject subject = new ProxyClass();

            Console.WriteLine(subject.Request());
            Console.WriteLine(subject.Request());

            ProtectionProxy subject2 = new ProtectionProxy();

            Console.WriteLine(subject2.Request());
            Console.WriteLine((subject2 as ProtectionProxy).Authenticate("Secret"));
            Console.WriteLine((subject2 as ProtectionProxy).Authenticate("Abracadabra"));
            Console.WriteLine(subject2.Request());

            Console.ReadLine();

        }
    }
}

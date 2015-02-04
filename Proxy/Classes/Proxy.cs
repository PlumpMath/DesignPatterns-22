using Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Classes
{
    public class ProxyClass : ISubject
    {
        Subject subject;

        public string Request()
        {
            if (subject == null)
            {
                Console.WriteLine("Subject inactive");
                subject = new Subject();
            }

            Console.WriteLine("Subject active");

            return "Proxy: Call to " + subject.Request();
        }
    }
}

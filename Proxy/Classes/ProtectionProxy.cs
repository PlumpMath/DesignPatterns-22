using Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Classes
{
    public class ProtectionProxy : ISubject
    {
        Subject subject;
        string password = "Abracadabra";

        public string Authenticate(string supplied)
        {
            if (supplied != password)
                return "Protected Proxy: No access";
            else
                subject = new Subject();

            return "Protection Proxy: Authenticated";
        }

        public string Request()
        {
            if (subject == null)
            {
                return "Protected Proxy: Authenticate first";
            }
            else
                return "Protection Proxy : Call to" + subject.Request();
        }
    }
}

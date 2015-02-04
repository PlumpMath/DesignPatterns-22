using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluggableAdapter.Classes
{
    class Adaptee
    {
        public double Precise(double a, double b) 
        {
            return a / b;        
        }
    }
}

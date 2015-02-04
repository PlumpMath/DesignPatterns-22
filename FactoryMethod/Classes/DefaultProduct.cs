using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Classes
{
    class DefaultProduct : IProduct
    {
        public string ShipFrom()
        {
            return "not available";        
        }
    }
}

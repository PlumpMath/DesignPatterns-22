using Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Classes
{
    class ImplementationA : IBridge
    {
        public string OperationImp()
        {
            return "ImplementationA";
        }
    }
}

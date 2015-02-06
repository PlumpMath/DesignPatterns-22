using Builder.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Interfaces
{
    interface IBuilder
    {
        void BuilderA();
        void BuilderB();
        Product GetResult();
    }
}

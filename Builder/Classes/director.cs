using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classes
{
    class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuilderA();
            builder.BuilderB();
            builder.BuilderB();
        }
    }
}

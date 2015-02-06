using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classes
{
    class Builder1 : IBuilder
    {
        private Product product = new Product();

        public void BuilderA()
        {
            product.Add("PartA ");
        }

        public void BuilderB()
        {
            product.Add("PartB ");
        }

        public Product GetResult()
        {
            return product;
        }
    }
}

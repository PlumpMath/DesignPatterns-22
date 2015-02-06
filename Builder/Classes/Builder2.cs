using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classes
{
    class Builder2 :IBuilder
    {
        private Product product = new Product();

        public void BuilderA()
        {
            product.Add("PartX ");            
        }

        public void BuilderB()
        {
            product.Add("PartY ");
        }

        public Product GetResult()
        {
            return product;
        }
    }
}

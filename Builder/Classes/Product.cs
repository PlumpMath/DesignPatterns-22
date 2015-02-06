using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classes
{
    class Product
    {
        List<string> parts = new List<string>();
        public void Add(string part) 
        {
            parts.Add(part);        
        }

        public void Display() 
        {
            Console.WriteLine("\nProduct Parts-----");
            foreach (var part in parts)
            {
                Console.Write(part);
            }

            Console.WriteLine();
        }
    }
}

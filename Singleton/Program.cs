using Singleton.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1 t1a = Singleton<Test1>.UniqueInstance;
            Test1 t1b = Singleton<Test1>.UniqueInstance;
            Test2 t2 = Singleton<Test2>.UniqueInstance;

            if (t1a == t1b)
            {
                Console.WriteLine("Objects are the same instance");            
            }

            Console.ReadLine();
        }
    }
}

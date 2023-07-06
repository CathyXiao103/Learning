using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class RealAction:IAction
    {
        public void Walk()
        {
            Console.WriteLine("Walking ...");
        }

        public void Run()
        {
            Console.WriteLine("Running ...");
        }

        public void Fly()
        {
            Console.WriteLine("Flying ...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class ProxyAction:IAction
    {
        public RealAction realAction;

        public void Walk()
        {
            Console.WriteLine("Proxy is preparing for walking...");
            realAction.Walk();
        }
    }
}

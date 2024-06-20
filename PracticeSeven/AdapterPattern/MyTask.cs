using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class MyTask
    {
        public void DoSomething()
        {
            var obj = new LegacyClass();
            obj.DoWork();
        }
    }
}

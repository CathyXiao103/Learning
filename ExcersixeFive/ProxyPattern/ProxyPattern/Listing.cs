using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern;
public class Listing:IChangeTracking
{
    public string GetDiff(string source, string target)
    {
        return "Listing detail is changed from "+source +" to "+target ;
    }
}

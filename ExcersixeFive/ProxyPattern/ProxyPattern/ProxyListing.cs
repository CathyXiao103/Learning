using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern;
public class ProxyListing:IChangeTracking
{
    private readonly Listing listing;

    public ProxyListing()
    {
        listing = new Listing();
    }

    public string GetDiff(string source, string target)
    {
        Console.WriteLine("Getting Listing difference:");
        return listing.GetDiff(source, target);
    }
}


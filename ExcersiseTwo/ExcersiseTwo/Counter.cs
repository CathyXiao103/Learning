using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcersiseTwo;

public class Counter
{
    public int InstanceCount { get; private set; }
    public static int TotalCount { get; private set; }

    public Counter()
    {
        InstanceCount++;
        TotalCount++;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern;

public interface IChangeTracking
{
    public string GetDiff(string source, string target);
}

public interface IAction
{
    void Walk();
    void Run();
    void Fly();
}
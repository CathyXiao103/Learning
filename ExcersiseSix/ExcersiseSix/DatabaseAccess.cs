using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcersiseSix;

public class DatabaseAccess : IDatabaseAccess
{
    public string GetUserInfo(string userId)
    {
        // Pretend we're accessing a database here...
        return $"User Info for {userId}";
    }
}

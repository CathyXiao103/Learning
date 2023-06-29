using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcersiseSix;

public class UserPermissionService : IUserPermissionService
{
    public bool UserHasAccess(string userId)
    {
        if (userId == null)
            return false;
        return true;
    }
}

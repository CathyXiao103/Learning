using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcersiseSix;
public class SecureDatabaseAccessProxy : IDatabaseAccess
{
    private readonly IDatabaseAccess _databaseAccess;
    private readonly IUserPermissionService _permissionService;

    public SecureDatabaseAccessProxy(IDatabaseAccess databaseAccess, IUserPermissionService permissionService)
    {
        _databaseAccess = databaseAccess;
        _permissionService = permissionService;
    }

    public string GetUserInfo(string userId)
    {
        if (_permissionService.UserHasAccess(userId))
        {
            return _databaseAccess.GetUserInfo(userId);
        }

        throw new UnauthorizedAccessException("User does not have access to this information.");
    }
}
using Abp.Authorization;
using Test1.Authorization.Roles;
using Test1.Authorization.Users;

namespace Test1.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

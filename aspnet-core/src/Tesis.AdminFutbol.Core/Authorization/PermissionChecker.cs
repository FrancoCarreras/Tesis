using Abp.Authorization;
using Tesis.AdminFutbol.Authorization.Roles;
using Tesis.AdminFutbol.Authorization.Users;

namespace Tesis.AdminFutbol.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

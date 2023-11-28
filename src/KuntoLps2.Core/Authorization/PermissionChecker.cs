using Abp.Authorization;
using KuntoLps2.Authorization.Roles;
using KuntoLps2.Authorization.Users;

namespace KuntoLps2.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

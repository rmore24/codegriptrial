using Abp.Authorization;
using TrialTemplate.Authorization.Roles;
using TrialTemplate.Authorization.Users;

namespace TrialTemplate.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Tesis.AdminFutbol.Controllers
{
    public abstract class AdminFutbolControllerBase: AbpController
    {
        protected AdminFutbolControllerBase()
        {
            LocalizationSourceName = AdminFutbolConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

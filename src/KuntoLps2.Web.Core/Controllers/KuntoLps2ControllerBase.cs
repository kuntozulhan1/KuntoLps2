using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace KuntoLps2.Controllers
{
    public abstract class KuntoLps2ControllerBase: AbpController
    {
        protected KuntoLps2ControllerBase()
        {
            LocalizationSourceName = KuntoLps2Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

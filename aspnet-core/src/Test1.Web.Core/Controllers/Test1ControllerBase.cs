using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Test1.Controllers
{
    public abstract class Test1ControllerBase: AbpController
    {
        protected Test1ControllerBase()
        {
            LocalizationSourceName = Test1Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

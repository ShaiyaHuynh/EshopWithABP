using EShop.IdentityService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EShop.IdentityService;

public abstract class IdentityServiceController : AbpControllerBase
{
    protected IdentityServiceController()
    {
        LocalizationResource = typeof(IdentityServiceResource);
    }
}

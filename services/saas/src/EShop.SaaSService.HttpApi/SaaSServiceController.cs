using EShop.SaaSService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EShop.SaaSService;

public abstract class SaaSServiceController : AbpControllerBase
{
    protected SaaSServiceController()
    {
        LocalizationResource = typeof(SaaSServiceResource);
    }
}

using EShop.AdministrationService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EShop.AdministrationService;

public abstract class AdministrationServiceController : AbpControllerBase
{
    protected AdministrationServiceController()
    {
        LocalizationResource = typeof(AdministrationServiceResource);
    }
}

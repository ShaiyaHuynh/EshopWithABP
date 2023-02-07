using EShop.SaaSService.Localization;
using Volo.Abp.Application.Services;

namespace EShop.SaaSService;

public abstract class SaaSServiceAppService : ApplicationService
{
    protected SaaSServiceAppService()
    {
        LocalizationResource = typeof(SaaSServiceResource);
        ObjectMapperContext = typeof(SaaSServiceApplicationModule);
    }
}

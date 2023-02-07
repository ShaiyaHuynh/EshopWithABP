using Volo.Abp.Modularity;

namespace EShop.IdentityService;

[DependsOn(
    typeof(IdentityServiceApplicationModule),
    typeof(IdentityServiceDomainTestModule)
    )]
public class IdentityServiceApplicationTestModule : AbpModule
{

}

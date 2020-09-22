using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace WM.TablePlatform.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(TablePlatformHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class TablePlatformConsoleApiClientModule : AbpModule
    {
        
    }
}

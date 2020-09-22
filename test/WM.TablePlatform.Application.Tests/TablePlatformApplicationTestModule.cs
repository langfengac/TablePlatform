using Volo.Abp.Modularity;

namespace WM.TablePlatform
{
    [DependsOn(
        typeof(TablePlatformApplicationModule),
        typeof(TablePlatformDomainTestModule)
        )]
    public class TablePlatformApplicationTestModule : AbpModule
    {

    }
}
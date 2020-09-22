using WM.TablePlatform.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace WM.TablePlatform
{
    [DependsOn(
        typeof(TablePlatformEntityFrameworkCoreTestModule)
        )]
    public class TablePlatformDomainTestModule : AbpModule
    {

    }
}
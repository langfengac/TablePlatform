using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace WM.TablePlatform.EntityFrameworkCore
{
    [DependsOn(
        typeof(TablePlatformEntityFrameworkCoreModule)
        )]
    public class TablePlatformEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<TablePlatformMigrationsDbContext>();
        }
    }
}

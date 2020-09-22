using WM.TablePlatform.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace WM.TablePlatform.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(TablePlatformEntityFrameworkCoreDbMigrationsModule),
        typeof(TablePlatformApplicationContractsModule)
        )]
    public class TablePlatformDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}

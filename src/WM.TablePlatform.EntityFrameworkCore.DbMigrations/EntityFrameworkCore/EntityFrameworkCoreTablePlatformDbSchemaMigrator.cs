using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WM.TablePlatform.Data;
using Volo.Abp.DependencyInjection;

namespace WM.TablePlatform.EntityFrameworkCore
{
    public class EntityFrameworkCoreTablePlatformDbSchemaMigrator
        : ITablePlatformDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreTablePlatformDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the TablePlatformMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<TablePlatformMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
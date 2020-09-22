using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace WM.TablePlatform.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class TablePlatformMigrationsDbContextFactory : IDesignTimeDbContextFactory<TablePlatformMigrationsDbContext>
    {
        public TablePlatformMigrationsDbContext CreateDbContext(string[] args)
        {
            TablePlatformEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<TablePlatformMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new TablePlatformMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../WM.TablePlatform.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}

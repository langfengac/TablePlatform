using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace WM.TablePlatform.EntityFrameworkCore
{
    public static class TablePlatformDbContextModelCreatingExtensions
    {
        public static void ConfigureTablePlatform(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(TablePlatformConsts.DbTablePrefix + "YourEntities", TablePlatformConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}
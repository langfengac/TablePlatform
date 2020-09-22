using System.Threading.Tasks;

namespace WM.TablePlatform.Data
{
    public interface ITablePlatformDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}

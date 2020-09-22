using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace WM.TablePlatform.Web
{
    [Dependency(ReplaceServices = true)]
    public class TablePlatformBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "TablePlatform";
    }
}

using WM.TablePlatform.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace WM.TablePlatform.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class TablePlatformPageModel : AbpPageModel
    {
        protected TablePlatformPageModel()
        {
            LocalizationResourceType = typeof(TablePlatformResource);
        }
    }
}
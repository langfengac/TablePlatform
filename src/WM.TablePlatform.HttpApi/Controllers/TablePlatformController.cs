using WM.TablePlatform.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace WM.TablePlatform.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class TablePlatformController : AbpController
    {
        protected TablePlatformController()
        {
            LocalizationResource = typeof(TablePlatformResource);
        }
    }
}
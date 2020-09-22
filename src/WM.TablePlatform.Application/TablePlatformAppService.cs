using System;
using System.Collections.Generic;
using System.Text;
using WM.TablePlatform.Localization;
using Volo.Abp.Application.Services;

namespace WM.TablePlatform
{
    /* Inherit your application services from this class.
     */
    public abstract class TablePlatformAppService : ApplicationService
    {
        protected TablePlatformAppService()
        {
            LocalizationResource = typeof(TablePlatformResource);
        }
    }
}

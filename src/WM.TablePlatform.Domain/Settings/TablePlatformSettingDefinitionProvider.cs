using Volo.Abp.Settings;

namespace WM.TablePlatform.Settings
{
    public class TablePlatformSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(TablePlatformSettings.MySetting1));
        }
    }
}

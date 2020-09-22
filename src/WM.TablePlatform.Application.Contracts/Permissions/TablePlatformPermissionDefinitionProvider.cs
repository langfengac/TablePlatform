using WM.TablePlatform.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace WM.TablePlatform.Permissions
{
    public class TablePlatformPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(TablePlatformPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(TablePlatformPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<TablePlatformResource>(name);
        }
    }
}

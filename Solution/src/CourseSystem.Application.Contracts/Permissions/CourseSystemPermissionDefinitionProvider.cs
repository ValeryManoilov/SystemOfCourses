using CourseSystem.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace CourseSystem.Permissions;

public class CourseSystemPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CourseSystemPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(CourseSystemPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CourseSystemResource>(name);
    }
}

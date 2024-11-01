using Volo.Abp.Settings;

namespace Acme.SystemOfCourses.Settings;

public class SystemOfCoursesSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SystemOfCoursesSettings.MySetting1));
    }
}

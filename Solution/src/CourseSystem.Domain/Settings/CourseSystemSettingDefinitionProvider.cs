using Volo.Abp.Settings;

namespace CourseSystem.Settings;

public class CourseSystemSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CourseSystemSettings.MySetting1));
    }
}

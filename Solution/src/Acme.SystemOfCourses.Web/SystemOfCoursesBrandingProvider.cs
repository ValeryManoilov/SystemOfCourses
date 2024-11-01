using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using Acme.SystemOfCourses.Localization;

namespace Acme.SystemOfCourses.Web;

[Dependency(ReplaceServices = true)]
public class SystemOfCoursesBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<SystemOfCoursesResource> _localizer;

    public SystemOfCoursesBrandingProvider(IStringLocalizer<SystemOfCoursesResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}

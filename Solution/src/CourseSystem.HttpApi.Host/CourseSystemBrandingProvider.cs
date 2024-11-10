using Microsoft.Extensions.Localization;
using CourseSystem.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace CourseSystem;

[Dependency(ReplaceServices = true)]
public class CourseSystemBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<CourseSystemResource> _localizer;

    public CourseSystemBrandingProvider(IStringLocalizer<CourseSystemResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}

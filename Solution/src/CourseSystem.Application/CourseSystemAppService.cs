using CourseSystem.Localization;
using Volo.Abp.Application.Services;

namespace CourseSystem;

/* Inherit your application services from this class.
 */
public abstract class CourseSystemAppService : ApplicationService
{
    protected CourseSystemAppService()
    {
        LocalizationResource = typeof(CourseSystemResource);
    }
}

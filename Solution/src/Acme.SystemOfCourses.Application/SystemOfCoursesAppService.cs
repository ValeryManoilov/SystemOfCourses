using Acme.SystemOfCourses.Localization;
using Volo.Abp.Application.Services;

namespace Acme.SystemOfCourses;

/* Inherit your application services from this class.
 */
public abstract class SystemOfCoursesAppService : ApplicationService
{
    protected SystemOfCoursesAppService()
    {
        LocalizationResource = typeof(SystemOfCoursesResource);
    }
}

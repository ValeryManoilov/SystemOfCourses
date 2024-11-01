using Acme.SystemOfCourses.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.SystemOfCourses.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SystemOfCoursesController : AbpControllerBase
{
    protected SystemOfCoursesController()
    {
        LocalizationResource = typeof(SystemOfCoursesResource);
    }
}

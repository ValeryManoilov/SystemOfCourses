using CourseSystem.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CourseSystem.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CourseSystemController : AbpControllerBase
{
    protected CourseSystemController()
    {
        LocalizationResource = typeof(CourseSystemResource);
    }
}

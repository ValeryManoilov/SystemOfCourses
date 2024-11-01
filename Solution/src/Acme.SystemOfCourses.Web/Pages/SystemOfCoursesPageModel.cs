using Acme.SystemOfCourses.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.SystemOfCourses.Web.Pages;

public abstract class SystemOfCoursesPageModel : AbpPageModel
{
    protected SystemOfCoursesPageModel()
    {
        LocalizationResourceType = typeof(SystemOfCoursesResource);
    }
}

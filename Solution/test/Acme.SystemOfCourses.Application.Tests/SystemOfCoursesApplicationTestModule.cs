using Volo.Abp.Modularity;

namespace Acme.SystemOfCourses;

[DependsOn(
    typeof(SystemOfCoursesApplicationModule),
    typeof(SystemOfCoursesDomainTestModule)
)]
public class SystemOfCoursesApplicationTestModule : AbpModule
{

}

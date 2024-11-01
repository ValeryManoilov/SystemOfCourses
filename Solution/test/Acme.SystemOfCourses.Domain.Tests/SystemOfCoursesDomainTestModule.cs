using Volo.Abp.Modularity;

namespace Acme.SystemOfCourses;

[DependsOn(
    typeof(SystemOfCoursesDomainModule),
    typeof(SystemOfCoursesTestBaseModule)
)]
public class SystemOfCoursesDomainTestModule : AbpModule
{

}

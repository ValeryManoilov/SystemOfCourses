using Volo.Abp.Modularity;

namespace Acme.SystemOfCourses;

public abstract class SystemOfCoursesApplicationTestBase<TStartupModule> : SystemOfCoursesTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

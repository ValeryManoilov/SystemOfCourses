using Volo.Abp.Modularity;

namespace Acme.SystemOfCourses;

/* Inherit from this class for your domain layer tests. */
public abstract class SystemOfCoursesDomainTestBase<TStartupModule> : SystemOfCoursesTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

using Volo.Abp.Modularity;

namespace CourseSystem;

/* Inherit from this class for your domain layer tests. */
public abstract class CourseSystemDomainTestBase<TStartupModule> : CourseSystemTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

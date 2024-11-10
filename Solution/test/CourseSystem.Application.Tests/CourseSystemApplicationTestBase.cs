using Volo.Abp.Modularity;

namespace CourseSystem;

public abstract class CourseSystemApplicationTestBase<TStartupModule> : CourseSystemTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

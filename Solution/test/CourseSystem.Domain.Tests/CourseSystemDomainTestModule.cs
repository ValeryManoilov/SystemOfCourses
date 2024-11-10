using Volo.Abp.Modularity;

namespace CourseSystem;

[DependsOn(
    typeof(CourseSystemDomainModule),
    typeof(CourseSystemTestBaseModule)
)]
public class CourseSystemDomainTestModule : AbpModule
{

}

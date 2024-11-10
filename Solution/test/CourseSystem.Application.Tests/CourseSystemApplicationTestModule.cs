using Volo.Abp.Modularity;

namespace CourseSystem;

[DependsOn(
    typeof(CourseSystemApplicationModule),
    typeof(CourseSystemDomainTestModule)
)]
public class CourseSystemApplicationTestModule : AbpModule
{

}

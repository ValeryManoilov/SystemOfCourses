using CourseSystem.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace CourseSystem.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CourseSystemEntityFrameworkCoreModule),
    typeof(CourseSystemApplicationContractsModule)
)]
public class CourseSystemDbMigratorModule : AbpModule
{
}

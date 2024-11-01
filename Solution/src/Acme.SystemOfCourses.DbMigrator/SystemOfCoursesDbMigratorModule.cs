using Acme.SystemOfCourses.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.SystemOfCourses.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SystemOfCoursesEntityFrameworkCoreModule),
    typeof(SystemOfCoursesApplicationContractsModule)
)]
public class SystemOfCoursesDbMigratorModule : AbpModule
{
}

using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.SystemOfCourses.Data;

/* This is used if database provider does't define
 * ISystemOfCoursesDbSchemaMigrator implementation.
 */
public class NullSystemOfCoursesDbSchemaMigrator : ISystemOfCoursesDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CourseSystem.Data;

/* This is used if database provider does't define
 * ICourseSystemDbSchemaMigrator implementation.
 */
public class NullCourseSystemDbSchemaMigrator : ICourseSystemDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

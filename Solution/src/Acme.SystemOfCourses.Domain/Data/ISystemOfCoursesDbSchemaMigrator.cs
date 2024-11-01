using System.Threading.Tasks;

namespace Acme.SystemOfCourses.Data;

public interface ISystemOfCoursesDbSchemaMigrator
{
    Task MigrateAsync();
}

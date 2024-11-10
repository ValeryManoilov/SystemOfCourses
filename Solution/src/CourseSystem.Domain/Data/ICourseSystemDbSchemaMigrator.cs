using System.Threading.Tasks;

namespace CourseSystem.Data;

public interface ICourseSystemDbSchemaMigrator
{
    Task MigrateAsync();
}

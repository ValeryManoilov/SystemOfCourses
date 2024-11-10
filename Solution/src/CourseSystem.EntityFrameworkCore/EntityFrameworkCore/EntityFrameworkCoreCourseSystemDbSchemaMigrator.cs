using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CourseSystem.Data;
using Volo.Abp.DependencyInjection;

namespace CourseSystem.EntityFrameworkCore;

public class EntityFrameworkCoreCourseSystemDbSchemaMigrator
    : ICourseSystemDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCourseSystemDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the CourseSystemDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CourseSystemDbContext>()
            .Database
            .MigrateAsync();
    }
}

using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.SystemOfCourses.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.SystemOfCourses.EntityFrameworkCore;

public class EntityFrameworkCoreSystemOfCoursesDbSchemaMigrator
    : ISystemOfCoursesDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSystemOfCoursesDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SystemOfCoursesDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SystemOfCoursesDbContext>()
            .Database
            .MigrateAsync();
    }
}

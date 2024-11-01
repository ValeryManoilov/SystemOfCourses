using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.SystemOfCourses.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class SystemOfCoursesDbContextFactory : IDesignTimeDbContextFactory<SystemOfCoursesDbContext>
{
    public SystemOfCoursesDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        SystemOfCoursesEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<SystemOfCoursesDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new SystemOfCoursesDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Acme.SystemOfCourses.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}

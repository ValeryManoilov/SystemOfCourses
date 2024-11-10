using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CourseSystem.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class CourseSystemDbContextFactory : IDesignTimeDbContextFactory<CourseSystemDbContext>
{
    public CourseSystemDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        CourseSystemEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<CourseSystemDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new CourseSystemDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../CourseSystem.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}

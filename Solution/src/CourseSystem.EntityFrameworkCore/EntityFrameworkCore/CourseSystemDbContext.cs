using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.BlobStoring.Database.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;
using CourseSystem.Models;
using System.Reflection.Emit;

namespace CourseSystem.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class CourseSystemDbContext :
    AbpDbContext<CourseSystemDbContext>,
    ITenantManagementDbContext,
    IIdentityDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    public DbSet<Course> Courses { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Tag> Tags { get; set; }


    #region Entities from the modules

    /* Notice: We only implemented IIdentityProDbContext and ISaasDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityProDbContext and ISaasDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    // Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }
    public DbSet<IdentitySession> Sessions { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion

    public CourseSystemDbContext(DbContextOptions<CourseSystemDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureFeatureManagement();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureTenantManagement();
        builder.ConfigureBlobStoring();

        /* Configure your own tables/entities inside here */

        builder.Entity<Course>(c =>
        {
            c.ToTable(CourseSystemConsts.DbTablePrefix + "Courses", CourseSystemConsts.DbSchema);
            c.ConfigureByConvention();
            c.Property(x => x.Id).IsRequired();
            c.Property(x => x.CourseName).IsRequired();
            c.Property(x => x.Description).IsRequired();

            c.HasMany(c => c.Lessons).WithOne().HasForeignKey(l => l.CourseId);
        });

        builder.Entity<Lesson>(l =>
        {
            l.ToTable(CourseSystemConsts.DbTablePrefix + "Lessons", CourseSystemConsts.DbSchema);
            l.ConfigureByConvention();
            l.Property(x => x.Id).IsRequired();
            l.Property(x => x.LessonName).IsRequired();
            l.Property(x => x.CourseId).IsRequired();
            l.Property(x => x.Description).IsRequired().HasMaxLength(1000);
            l.Property(x => x.Route).IsRequired().HasMaxLength(200);
            l.Property(x => x.Date).IsRequired();
        });

        builder.Entity<Tag>(t =>
        {
            t.ToTable(CourseSystemConsts.DbTablePrefix + "Tags", CourseSystemConsts.DbSchema);
            t.ConfigureByConvention();
            t.Property(x => x.Id).IsRequired();
            t.Property(x => x.TagName).IsRequired().HasMaxLength(200);
        });
        builder.Entity<LessonTag>().HasKey(lt => new { lt.LessonId, lt.TagId });

        builder.Entity<LessonTag>().HasOne(lt => lt.Lesson).WithMany(l => l.LessonTags).HasForeignKey(lt => lt.LessonId);

        builder.Entity<LessonTag>().HasOne(lt => lt.Tag).WithMany(t => t.LessonTags).HasForeignKey(lt => lt.TagId);
    }
}

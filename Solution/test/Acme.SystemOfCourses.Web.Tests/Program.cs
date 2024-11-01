using Microsoft.AspNetCore.Builder;
using Acme.SystemOfCourses;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<SystemOfCoursesWebTestModule>();

public partial class Program
{
}

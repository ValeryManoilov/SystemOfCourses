using Xunit;

namespace Acme.SystemOfCourses.EntityFrameworkCore;

[CollectionDefinition(SystemOfCoursesTestConsts.CollectionDefinitionName)]
public class SystemOfCoursesEntityFrameworkCoreCollection : ICollectionFixture<SystemOfCoursesEntityFrameworkCoreFixture>
{

}

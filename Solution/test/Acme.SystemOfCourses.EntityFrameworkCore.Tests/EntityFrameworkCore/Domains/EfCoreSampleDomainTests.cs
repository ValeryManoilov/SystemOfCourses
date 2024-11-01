using Acme.SystemOfCourses.Samples;
using Xunit;

namespace Acme.SystemOfCourses.EntityFrameworkCore.Domains;

[Collection(SystemOfCoursesTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<SystemOfCoursesEntityFrameworkCoreTestModule>
{

}

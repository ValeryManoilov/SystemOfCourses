using Acme.SystemOfCourses.Samples;
using Xunit;

namespace Acme.SystemOfCourses.EntityFrameworkCore.Applications;

[Collection(SystemOfCoursesTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<SystemOfCoursesEntityFrameworkCoreTestModule>
{

}

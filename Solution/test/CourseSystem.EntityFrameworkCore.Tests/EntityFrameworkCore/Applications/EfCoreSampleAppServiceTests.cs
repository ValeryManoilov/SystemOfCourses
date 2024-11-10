using CourseSystem.Samples;
using Xunit;

namespace CourseSystem.EntityFrameworkCore.Applications;

[Collection(CourseSystemTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<CourseSystemEntityFrameworkCoreTestModule>
{

}

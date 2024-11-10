using CourseSystem.Samples;
using Xunit;

namespace CourseSystem.EntityFrameworkCore.Domains;

[Collection(CourseSystemTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<CourseSystemEntityFrameworkCoreTestModule>
{

}

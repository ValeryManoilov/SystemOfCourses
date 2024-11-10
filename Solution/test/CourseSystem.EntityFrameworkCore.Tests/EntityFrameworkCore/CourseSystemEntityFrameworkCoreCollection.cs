using Xunit;

namespace CourseSystem.EntityFrameworkCore;

[CollectionDefinition(CourseSystemTestConsts.CollectionDefinitionName)]
public class CourseSystemEntityFrameworkCoreCollection : ICollectionFixture<CourseSystemEntityFrameworkCoreFixture>
{

}

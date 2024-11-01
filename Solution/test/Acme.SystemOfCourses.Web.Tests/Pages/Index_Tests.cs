using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.SystemOfCourses.Pages;

[Collection(SystemOfCoursesTestConsts.CollectionDefinitionName)]
public class Index_Tests : SystemOfCoursesWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}

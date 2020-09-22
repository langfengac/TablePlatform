using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace WM.TablePlatform.Pages
{
    public class Index_Tests : TablePlatformWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}

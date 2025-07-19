using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Omdh.Accounting.Pages;

[Collection(AccountingTestConsts.CollectionDefinitionName)]
public class Index_Tests : AccountingWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}

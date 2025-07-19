using Omdh.Accounting.Samples;
using Xunit;

namespace Omdh.Accounting.EntityFrameworkCore.Applications;

[Collection(AccountingTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AccountingEntityFrameworkCoreTestModule>
{

}

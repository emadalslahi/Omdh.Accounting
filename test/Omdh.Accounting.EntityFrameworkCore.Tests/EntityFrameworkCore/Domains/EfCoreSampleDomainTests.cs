using Omdh.Accounting.Samples;
using Xunit;

namespace Omdh.Accounting.EntityFrameworkCore.Domains;

[Collection(AccountingTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AccountingEntityFrameworkCoreTestModule>
{

}

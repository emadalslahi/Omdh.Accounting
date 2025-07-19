using Xunit;

namespace Omdh.Accounting.EntityFrameworkCore;

[CollectionDefinition(AccountingTestConsts.CollectionDefinitionName)]
public class AccountingEntityFrameworkCoreCollection : ICollectionFixture<AccountingEntityFrameworkCoreFixture>
{

}

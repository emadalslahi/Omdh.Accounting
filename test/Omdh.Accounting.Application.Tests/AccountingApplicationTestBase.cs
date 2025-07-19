using Volo.Abp.Modularity;

namespace Omdh.Accounting;

public abstract class AccountingApplicationTestBase<TStartupModule> : AccountingTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

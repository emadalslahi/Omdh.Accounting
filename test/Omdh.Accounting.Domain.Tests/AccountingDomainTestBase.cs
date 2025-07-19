using Volo.Abp.Modularity;

namespace Omdh.Accounting;

/* Inherit from this class for your domain layer tests. */
public abstract class AccountingDomainTestBase<TStartupModule> : AccountingTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

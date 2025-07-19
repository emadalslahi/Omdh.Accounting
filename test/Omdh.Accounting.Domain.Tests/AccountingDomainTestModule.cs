using Volo.Abp.Modularity;

namespace Omdh.Accounting;

[DependsOn(
    typeof(AccountingDomainModule),
    typeof(AccountingTestBaseModule)
)]
public class AccountingDomainTestModule : AbpModule
{

}

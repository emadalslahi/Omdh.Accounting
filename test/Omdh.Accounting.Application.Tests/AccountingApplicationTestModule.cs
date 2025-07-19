using Volo.Abp.Modularity;

namespace Omdh.Accounting;

[DependsOn(
    typeof(AccountingApplicationModule),
    typeof(AccountingDomainTestModule)
)]
public class AccountingApplicationTestModule : AbpModule
{

}

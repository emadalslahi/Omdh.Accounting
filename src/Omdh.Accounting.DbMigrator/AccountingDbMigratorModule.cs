using Omdh.Accounting.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Omdh.Accounting.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AccountingEntityFrameworkCoreModule),
    typeof(AccountingApplicationContractsModule)
)]
public class AccountingDbMigratorModule : AbpModule
{
}

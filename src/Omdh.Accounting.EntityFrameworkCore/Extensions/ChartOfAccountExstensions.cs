using Microsoft.EntityFrameworkCore;
using Omdh.Accounting.ChartOfAccounts;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Omdh.Accounting.Extensions;

public static class ChartOfAccountExstensions
{
    public static void ConfigureChartOfAccountEntity(this ModelBuilder builder)
    {

        _ = builder.Entity<ChartOfAccount>(b =>
        {
            _ = b.ToTable( "ChartOfAccounts",AccountingConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            _ = b.Property(x => x.Name).IsRequired().HasMaxLength(255);
            _ = b.Property(x => x.Description).IsRequired().HasMaxLength(1000);
            _ = b.Property(x => x.Code).IsRequired().HasMaxLength(50);
            _ = b.Property(x => x.AccountType).IsRequired();
            _ = b.Property(x => x.AccountCategory).IsRequired();
            _ = b.Property(x => x.AccountNo).IsRequired();
            _ = b.Property(x => x.AccountLevel).IsRequired();
        });
    }

}

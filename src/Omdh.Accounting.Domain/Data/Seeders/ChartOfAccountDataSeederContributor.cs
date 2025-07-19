using Omdh.Accounting.Accounts;
using Omdh.Accounting.ChartOfAccounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Omdh.Accounting.Data.Seeders;

public class ChartOfAccountDataSeederContributor(IRepository<ChartOfAccount, Guid> _repository) : 
    IDataSeedContributor, ITransientDependency
{
    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _repository.GetCountAsync() > 0)
        {
            return; // Data already seeded
        }
        var chartOfAccounts = new List<ChartOfAccount>
        {
            new ChartOfAccount
            {
                Name = "Cash",
                Description = "Cash in hand",
                AccountNo = 1001,
                AccountLevel = 1,
                ParentAccountNo = 0,
                Code = "CASH",
                AccountType = AccountType.FixedAsset,
                AccountCategory = AccountCategory.Asset,
                AccountStatus = AccountStatus.Active,

            },
            new ChartOfAccount
            {
                Name = "Accounts Receivable",
                Description = "Money owed by customers",
                AccountNo = 1002,
                AccountLevel = 1,
                ParentAccountNo = 0,
                Code = "AR",
                AccountType = AccountType.OtherLiability,
                AccountCategory = AccountCategory.Liability,
                AccountStatus = AccountStatus.Active
            },
            new ChartOfAccount
            {
                Name = "Inventory",
                Description = "Goods available for sale",
                AccountNo = 1003,
                AccountLevel = 1,
                ParentAccountNo = 0,
                Code = "INV",
                AccountType = AccountType.Inventory,
                AccountCategory = AccountCategory.Asset,
                AccountStatus = AccountStatus.Active
            }
        };

        await _repository.InsertManyAsync(chartOfAccounts, autoSave: true);

    }
}

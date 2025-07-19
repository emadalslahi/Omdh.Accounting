using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Omdh.Accounting.ChartOfAccounts;

public class ChartOfAccountAppService :
     CrudAppService< //Defines CRUD methods
        ChartOfAccount,
        ChartOfAccountDto, //Used to show Chart Of Accounts 
        Guid, //Primary key of the ChartOFAcct entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateChartOfAccountDto>, //Used to create/update a Chart of Accounts
        IChartOfAccountAppService
{

    public ChartOfAccountAppService(IRepository<ChartOfAccount, Guid> repository) : base(repository)
    {
    }
}

using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Omdh.Accounting.ChartOfAccounts;

public interface IChartOfAccountAppService :
     ICrudAppService< //Defines CRUD methods
        ChartOfAccountDto, //Used to show Chart Of Accounts 
        Guid, //Primary key of the ChartOFAcct entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateChartOfAccountDto> //Used to create/update a Chart of Accounts
{
}

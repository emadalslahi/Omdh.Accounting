using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Omdh.Accounting.ChartOfAccounts;

public class ChartOfAccountAppService(IRepository<ChartOfAccount, Guid> repository) :
    CrudAppService< //Defines CRUD methods
        ChartOfAccount,
        ChartOfAccountDto, //Used to show Chart Of Accounts 
        Guid, //Primary key of the ChartOFAcct entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateChartOfAccountDto>(repository), //Used to create/update a Chart of Accounts
    IChartOfAccountAppService;

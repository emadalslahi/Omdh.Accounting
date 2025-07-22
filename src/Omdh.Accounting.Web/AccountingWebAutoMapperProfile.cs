using AutoMapper;
using Omdh.Accounting.ChartOfAccounts;

namespace Omdh.Accounting.Web;

public class AccountingWebAutoMapperProfile : Profile
{
    public AccountingWebAutoMapperProfile()
    {
        //Define your object mappings here, for the Web project

        CreateMap<ChartOfAccountDto, CreateUpdateChartOfAccountDto>();

    }
}

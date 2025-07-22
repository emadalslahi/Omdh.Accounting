using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Omdh.Accounting.ChartOfAccounts;

namespace Omdh.Accounting.Web.Pages.ChartOfAccounts;


public class EditModalModel(IChartOfAccountAppService appService) : AccountingPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty] public CreateUpdateChartOfAccountDto ChartOfAccount { get; set; } =new();

    private  IChartOfAccountAppService _appService = appService;

    // this constructor is used for dependency injection in the Razor Pages 
    // this constructor will fix the bug of Cross-Site Request Forgery (CSRF) token validation failure
    //public EditModalModel(IChartOfAccountAppService appService)
    //{
    //    _appService = appService;
    //}
    public async Task OnGetAsync()
    {
        
        var dto = await _appService.GetAsync(Id);
        ChartOfAccount = ObjectMapper.Map<ChartOfAccountDto, CreateUpdateChartOfAccountDto>(dto);
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _appService.UpdateAsync(Id, ChartOfAccount);
        return NoContent();
    }
}
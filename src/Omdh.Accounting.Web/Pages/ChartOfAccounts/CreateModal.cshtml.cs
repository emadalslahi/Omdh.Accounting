using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Omdh.Accounting.ChartOfAccounts;
using Omdh.Accounting.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Omdh.Accounting.Web.Pages.ChartOfAccounts;

public class CreateModalModel(IChartOfAccountAppService appService) : AccountingPageModel
{

    [BindProperty]
    public required CreateUpdateChartOfAccountDto ChartOfAccountDto { get; set; }

    // this constructor will fix the bug of Cross-Site Request Forgery (CSRF) token validation failure
    //public CreateModalModel(IChartOfAccountAppService appService)
    //{
    //    _appService = appService;
    //}
    public void OnGet()
    {
        ChartOfAccountDto = new CreateUpdateChartOfAccountDto();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await appService.CreateAsync(ChartOfAccountDto);
        return NoContent();
    }
}

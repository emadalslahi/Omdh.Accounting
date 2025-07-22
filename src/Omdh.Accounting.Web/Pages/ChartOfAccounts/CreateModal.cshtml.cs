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

public class CreateModalModel : AccountingPageModel
{

    [BindProperty]
    public CreateUpdateChartOfAccountDto ChartOfAccountDto { get; set; }

    private readonly IChartOfAccountAppService _AppService;

    public CreateModalModel(IChartOfAccountAppService AppService)
    {
        _AppService = AppService;
    }

    public void OnGet()
    {
        ChartOfAccountDto = new CreateUpdateChartOfAccountDto();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _AppService.CreateAsync(ChartOfAccountDto);
        return NoContent();
    }
}

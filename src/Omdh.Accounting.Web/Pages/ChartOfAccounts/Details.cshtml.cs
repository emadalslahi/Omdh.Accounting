using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Omdh.Accounting.ChartOfAccounts;
using Omdh.Accounting.EntityFrameworkCore;

namespace Omdh.Accounting.Web.Pages.ChartOfAccounts
{
    public class DetailsModel : PageModel
    {
        private readonly Omdh.Accounting.EntityFrameworkCore.AccountingDbContext _context;

        public DetailsModel(Omdh.Accounting.EntityFrameworkCore.AccountingDbContext context)
        {
            _context = context;
        }

        public ChartOfAccount ChartOfAccount { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chartofaccount = await _context.ChartOfAccounts.FirstOrDefaultAsync(m => m.Id == id);

            if (chartofaccount is not null)
            {
                ChartOfAccount = chartofaccount;

                return Page();
            }

            return NotFound();
        }
    }
}

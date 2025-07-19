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
    public class DeleteModel : PageModel
    {
        private readonly Omdh.Accounting.EntityFrameworkCore.AccountingDbContext _context;

        public DeleteModel(Omdh.Accounting.EntityFrameworkCore.AccountingDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chartofaccount = await _context.ChartOfAccounts.FindAsync(id);
            if (chartofaccount != null)
            {
                ChartOfAccount = chartofaccount;
                _context.ChartOfAccounts.Remove(ChartOfAccount);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

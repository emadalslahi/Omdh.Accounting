using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Omdh.Accounting.ChartOfAccounts;
using Omdh.Accounting.EntityFrameworkCore;

namespace Omdh.Accounting.Web.Pages.ChartOfAccounts
{
    public class EditModel : PageModel
    {
        private readonly Omdh.Accounting.EntityFrameworkCore.AccountingDbContext _context;

        public EditModel(Omdh.Accounting.EntityFrameworkCore.AccountingDbContext context)
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

            var chartofaccount =  await _context.ChartOfAccounts.FirstOrDefaultAsync(m => m.Id == id);
            if (chartofaccount == null)
            {
                return NotFound();
            }
            ChartOfAccount = chartofaccount;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ChartOfAccount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChartOfAccountExists(ChartOfAccount.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ChartOfAccountExists(Guid id)
        {
            return _context.ChartOfAccounts.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Omdh.Accounting.ChartOfAccounts;
using Omdh.Accounting.EntityFrameworkCore;

namespace Omdh.Accounting.Web.Pages.ChartOfAccounts
{
    public class CreateModel : PageModel
    {
        private readonly Omdh.Accounting.EntityFrameworkCore.AccountingDbContext _context;

        public CreateModel(Omdh.Accounting.EntityFrameworkCore.AccountingDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ChartOfAccount ChartOfAccount { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ChartOfAccounts.Add(ChartOfAccount);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

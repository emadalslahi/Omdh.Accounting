using Omdh.Accounting.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omdh.Accounting.ChartOfAccounts
{
    public  class CreateUpdateChartOfAccountDto
    {
        [Required]
        [StringLength(256)]
        public string Name { get; set; } = string.Empty;

        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;
        [Required]
        [MinLength(4)]
        public int AccountNo { get; set; } = default!;
        [Required]
        public int AccountLevel { get; set; } = default!;
        public int ParentAccountNo { get; set; } = default!;
        [Required]
        public string Code { get; set; } = string.Empty;
        [Required]
        public AccountType AccountType { get; set; } = AccountType.NotSet;
        [Required]
        public AccountCategory AccountCategory { get; set; } = AccountCategory.Other;
   
    }
}

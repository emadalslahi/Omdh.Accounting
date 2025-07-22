using Omdh.Accounting.Accounts;
using System.ComponentModel.DataAnnotations;

namespace Omdh.Accounting.ChartOfAccounts
{
    public  class CreateUpdateChartOfAccountDto
    {
        [Required]
        [StringLength(256)]
        public string Name { get; set; } = string.Empty;

        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;


        // minlength here is cousing cross-site request forgery (CSRF) token validation failure
        [Required]
        [MinLength(4)]
        public int AccountNo { get; set; } 
        [Required]
        public int AccountLevel { get; set; }
        public int ParentAccountNo { get; set; }
        [Required]
        public string Code { get; set; } = string.Empty;
        [Required]
        public AccountType AccountType { get; set; } = AccountType.NotSet;
        [Required]
        public AccountCategory AccountCategory { get; set; } = AccountCategory.Other;
   
    }
}

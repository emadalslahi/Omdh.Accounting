using Omdh.Accounting.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Omdh.Accounting.Web.Pages;

public abstract class AccountingPageModel : AbpPageModel
{
    protected AccountingPageModel()
    {
        LocalizationResourceType = typeof(AccountingResource);
    }
}

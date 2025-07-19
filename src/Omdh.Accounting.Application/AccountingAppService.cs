using Omdh.Accounting.Localization;
using Volo.Abp.Application.Services;

namespace Omdh.Accounting;

/* Inherit your application services from this class.
 */
public abstract class AccountingAppService : ApplicationService
{
    protected AccountingAppService()
    {
        LocalizationResource = typeof(AccountingResource);
    }
}

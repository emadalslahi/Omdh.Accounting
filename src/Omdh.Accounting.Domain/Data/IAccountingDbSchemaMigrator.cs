using System.Threading.Tasks;

namespace Omdh.Accounting.Data;

public interface IAccountingDbSchemaMigrator
{
    Task MigrateAsync();
}

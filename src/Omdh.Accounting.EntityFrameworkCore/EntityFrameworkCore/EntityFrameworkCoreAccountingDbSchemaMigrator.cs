using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Omdh.Accounting.Data;
using Volo.Abp.DependencyInjection;

namespace Omdh.Accounting.EntityFrameworkCore;

public class EntityFrameworkCoreAccountingDbSchemaMigrator
    : IAccountingDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAccountingDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AccountingDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AccountingDbContext>()
            .Database
            .MigrateAsync();
    }
}

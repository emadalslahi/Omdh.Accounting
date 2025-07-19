using Microsoft.AspNetCore.Builder;
using Omdh.Accounting;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("Omdh.Accounting.Web.csproj"); 
await builder.RunAbpModuleAsync<AccountingWebTestModule>(applicationName: "Omdh.Accounting.Web");

public partial class Program
{
}

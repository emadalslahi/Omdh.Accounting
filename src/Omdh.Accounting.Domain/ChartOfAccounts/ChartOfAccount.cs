using Omdh.Accounting.Accounts;
using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Omdh.Accounting.ChartOfAccounts;
/// <summary>
/// 
/// 
/// 
/// Add-Migration Created_ChartOfAccts_Entity -Context Omdh.Accounting.EntityFrameworkCore -o Migrations
/// Update-Database -Context Omdh.Accounting.EntityFrameworkCore
/// </summary>
public class ChartOfAccount : FullAuditedAggregateRoot<Guid>
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int AccountNo { get; set; } = default!;
    public int AccountLevel { get; set; } = default!;
    public int ParentAccountNo { get; set; } = default!;
    public string Code { get; set; } = string.Empty;
    public AccountType AccountType { get; set; } = AccountType.NotSet;
    public AccountCategory AccountCategory { get; set; } = AccountCategory.Other;
    public AccountStatus AccountStatus { get; set; } = AccountStatus.New;
    public   bool IsActive => AccountStatus == AccountStatus.Active;
}

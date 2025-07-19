$(function () {
    var l = abp.localization.getResource('Accounting');

    var dataTable = $('#ChartOfAccountsTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true, // omdh.accounting.chartOfAccounts.chartOfAccount.getList must by CamalCase
            ajax: abp.libs.datatables.createAjax(omdh.accounting.chartOfAccounts.chartOfAccount.getList),
            columnDefs: [

                {
                    title: l("Account Number"),
                    data: "accountNo"
                },
                {
                    title: l("Account Level"),
                    data: "accountLevel"
                },    {
                    title: l('Account Name'),
                    data: "name"
                },
                {
                    title: l("Account Code"),
                    data: "code"
                },
                {
                    title: l('Account Type'),
                    data: "accountType",
                    render: function (data) {
                        return l('Enum:AccountType.' + data);
                    }
                },
                
                {
                    title: l('Account Category'),
                    data: "accountCategory",
                    render: function (data) {
                        return l('Enum:AccountCategory.' + data);
                    }
                },

                {
                    title: l('Account Status'),
                    data: "accountStatus",
                    render: function (data) {
                        return l('Enum:AccountStatus.' + data);
                    }
                },
               
                {
                    title: l('CreationTime'), data: "creationTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
                }
            ]
        })
    );
});

## مقدمة

في هذه المرحلة نقوم بتنقيح تحليل النظام المحاسبي المتكامل، مع التركيز على تعزيز الواقعية والشمولية، وذكر كافة الجوانب التي قد تكون ناقصة أو بحاجة لتفصيل إضافي.

---

## 1. الوحدات الأساسية (المؤكدة)

1. **دليل الحسابات (Chart of Accounts)**
   - شجرة مرنة وديناميكية تسمح بإضافة وتعديل الحسابات.
2. **القيود المحاسبية**
   - إدخال يدوي.
   - قيود آلية مرتبطة بإصدارات المستندات (فواتير، سندات، رواتب).
3. **إدارة العملات المتعددة**
   - أسعار صرف مرنة مع تاريخ نافذة الأسعار.
4. **الفواتير والمستندات**
   - فواتير المبيعات والمشتريات.
   - سندات القبض والصرف.
   - سند قيد عام.
   - سندات المرتجعات.
5. **الحسابات المرتبطة**
   - عملاء.
   - موردون.
   - موظفون (لربط المصروفات الرواتب).
6. **التقارير المالية الأساسية**
   - دفتر اليومية.
   - دفتر الأستاذ.
   - ميزان المراجعة.
   - قائمة الدخل.
   - الميزانية العمومية.
   - تقارير أعمار الديون.
   - تقارير المصروفات حسب النوع.

---

## 2. الجوانب الناقصة والمطلوب إضافتها أو تعزيزها

1. **إدارة المخزون (Inventory Management)**
   - ربط المستودعات بالحسابات.
   - تتبع حركات الوارد والصادر.
   - تقييم المخزون بأساليب مختلفة (FIFO، LIFO، المتوسط).
2. **الأصول الثابتة (Fixed Assets)**
   - تسجيل مراكز تكلفة الأصول.
   - جدول اهتلاك سنوي/شهري.
   - نقل الأصول، تصنيف، وإخراج.
3. **الموازنة وخطط التدفقات النقدية (Budgeting & Cash Flow Planning)**
   - إعداد ميزانيات سنوية وفصلية.
   - مقارنة الأداء الفعلي مع الميزانيات.
   - تخطيط التدفقات النقدية وتحليل الفجوات.
4. **التصنيفات المحاسبية المتقدمة (Cost Center / Project Accounting)**
   - توزيع المصروفات والإيرادات حسب مراكز التكلفة أو المشاريع.
   - تقارير ربحية المشاريع.
5. **التقارير الضريبية والامتثال (Tax & Compliance)**
   - إعداد وإرسال تقارير ضريبة القيمة المضافة VAT/GST.
   - حساب الضرائب المعلقة.
   - إعداد التقارير الضريبية الدورية (سنوية/ربع سنوية).
6. **التسوية البنكية (Bank Reconciliation)**
   - مسح أو تحميل كشوف البنوك.
   - مطابقة الحركات مع القيود.
   - كشف الفروقات وإغلاق الفجوات.
7. **الإجراءات الأمنية والتحكم بالوصول (Security & Access Control)**
   - صلاحيات مستخدمين متعددة (قراءة/كتابة/اعتماد).
   - تدقيق النشاطات (Audit Trail).
8. **التكامل مع أنظمة أخرى (Integration)**
   - بوابة دفع إلكتروني.
   - الربط مع أنظمة إدارة المخازن أو نقاط البيع POS.
   - ربط بالموارد البشرية ونظم الرواتب.
9. **التقارير التحليلية والرسوم البيانية (Analytics & Dashboards)**
   - لوحات تحكم تفاعلية لمراقبة المؤشرات المالية.
   - إظهار اتجاهات الإيرادات والمصروفات.
10. **دعم الشركات المتعددة والمواءمة (Multi-Entity & Consolidation)**
    - إدارة شركات/فروع متعددة.
    - تجميع البيانات المالية وترحيل القيود البينية.

---

## 3. التوصيات

- **إضافة وحدة المخزون والأصول الثابتة** لضمان شمولية كاملة.
- **تفعيل الموازنة والتخطيط** لمراقبة الأداء المالي.
- **تعزيز الجوانب الضريبية والامتثال** لتقليل المخاطر القانونية.
- **تطوير واجهة تحكم وتصور** لسهولة متابعة المؤشرات.
- **تأمين البيانات وتهيئة صلاحيات** مفصلة لكل دور وظيفي.

---

## 4. الجداول الأساسية (Entities)

فيما يلي قائمة مفصلة للجداول (Entities) اللازمة، مع اسم الجدول باللغتين العربية والإنجليزية، المفتاح الأساسي، العلاقات (Foreign Keys)، ووصف مختصر لكل جدول:

| الجدول (Arabic)          | Table Name (English)      | Primary Key    | Foreign Keys                                                                                                  | الوصف (Description)                                                                                      |
|--------------------------|---------------------------|----------------|---------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------|
| الحسابات                 | Accounts                  | AccountID      | ParentAccountID → Accounts.AccountID                                                                         | شجرة الحسابات المحاسبية مع إمكانية تصنيف هرمي. ويمكن ربط حساب واحد بعدة عملات.                         |
| إعدادات النظام           | SystemSettings            | SettingID      | BaseCurrencyID → Currencies.CurrencyID                                                                       | إعدادات عامة، تشمل العملة المحلية الأساسية وإعدادات متعددة العملات.                                     |
| عملات الحساب             | AccountCurrencies         | ACID           | AccountID → Accounts.AccountID, CurrencyID → Currencies.CurrencyID                                           | ربط الحسابات بالعملات التي تعمل بها مع تحديد ما إذا كانت العملة أساسية لهذا الحساب.                    |
| العملات                  | Currencies                | CurrencyID     | -                                                                                                             | تعريف جميع العملات التي يستخدمها النظام.                                                                  |
| أسعار الصرف              | ExchangeRates             | RateID         | CurrencyID → Currencies.CurrencyID                                                                           | تسجيل أسعار صرف العملات بتاريخ محدد.                                                                       |
| قيود اليومية              | JournalEntries            | EntryID        | CurrencyID → Currencies.CurrencyID, CreatedBy → Users.UserID, EntryCategoryID → EntryCategories.CategoryID  | تسجيل المعاملات المحاسبية مع تفاصيل العملة والمستخدم والفئة.                                              |
| فئات القيود              | EntryCategories           | CategoryID     | -                                                                                                             | تصنيف عام للقيود (عملاء، موردين، موظفين، وكلاء، إلخ).                                                      |
| أنواع القيود              | EntryTypes                | TypeID         | ParentTypeID → EntryTypes.TypeID                                                                             | شجرة أنوع القيود (قيود بيع/شراء، موارد بشرية، نظامية، إلخ) مع التقسيم الفرعي.                             |
| أسطر القيود              | JournalEntryLines         | LineID         | EntryID → JournalEntries.EntryID, AccountID → Accounts.AccountID, CostCenterID → CostCenters.CostCenterID,  | تفاصيل الحسابات المدينة والدائنة لكل قيد مع ضبط فروق العملة.                                              |
| العملاء                   | Customers                 | CustomerID     | -                                                                                                             | بيانات العملاء مع حدود الاعتماد والعملات المقبولة.                                                       |
| الموردون                  | Vendors                   | VendorID       | -                                                                                                             | بيانات الموردين وشروط الدفع والعملات المدعومة.                                                          |
| الموظفون                  | Employees                 | EmployeeID     | DepartmentID → Departments.DepartmentID                                                                       | بيانات الموظفين والرواتب والمكافآت والخصومات.                                                            |
| الإدارات                  | Departments               | DepartmentID   | -                                                                                                             | هيكل تنظيمي للمنظمات والأقسام.                                                                           |
| الفواتير                  | Invoices                  | InvoiceID      | CustomerID/VendorID → Customers/Vendors, CurrencyID → Currencies.CurrencyID                                  | فواتير المبيعات والمشتريات بعملات متعددة.                                                                |
| أسطر الفاتورة             | InvoiceLines              | LineID         | InvoiceID → Invoices.InvoiceID, AccountID → Accounts.AccountID                                                | تفاصيل البنود على الفاتورة.                                                                              |
| المدفوعات                  | Payments                  | PaymentID      | RelatedInvoiceID → Invoices.InvoiceID, CurrencyID → Currencies.CurrencyID, BankAccountID → BankAccounts.BankAccountID | سجلات القبض والصرف وربطها بالفواتير.                                                                     |
| الحسابات البنكية           | BankAccounts              | BankAccountID  | -                                                                                                             | بيانات الحسابات المصرفية للشركة.                                                                          |
| كشوف الحساب البنكي        | BankStatements            | StatementID    | BankAccountID → BankAccounts.BankAccountID                                                                   | كشوف الحساب الشهرية.                                                                                     |
| تسوية البنك               | BankReconciliations       | ReconciliationID | StatementID → BankStatements.StatementID                                                                     | مطابقة القيود مع كشوف البنك وتوليد قيود فروق المصارف.                                                     |
| المخزون                   | InventoryItems            | ItemID         | -                                                                                                             | تعريف الأصناف والمنتجات الموجودة في المخازن.                                                              |
| المخازن                   | Warehouses                | WarehouseID    | ManagerID → Employees.EmployeeID                                                                             | مواقع ومستودعات تخزين الأصناف.                                                                           |
| حركات المخزون             | InventoryMovements        | MovementID     | ItemID → InventoryItems.ItemID, WarehouseID → Warehouses.WarehouseID                                         | تتبع حركة الوارد والصادر للأصناف.                                                                         |
| الأصول الثابتة            | FixedAssets               | AssetID        | DepartmentID → Departments.DepartmentID                                                                       | تسجيل الأصول الثابتة وبياناتها.                                                                           |
| اهتلاك الأصول             | AssetDepreciations         | DepreciationID | AssetID → FixedAssets.AssetID                                                                                | جدول حساب الاستهلاك الدوري للأصول.                                                                        |
| مراكز التكلفة             | CostCenters               | CostCenterID   | ManagerID → Employees.EmployeeID                                                                             | تقسيم المصروفات والإيرادات حسب مركز التكلفة.                                                             |
| المشاريع                  | Projects                  | ProjectID      | ManagerID → Employees.EmployeeID, BudgetID → Budgets.BudgetID                                                | بيانات المشاريع وربطها بالميزانيات.                                                                       |
| الميزانيات                | Budgets                   | BudgetID       | DepartmentID/ProjectID → Departments/Projects                                                                 | تخصيص الميزانيات سنوياً أو لمشروع معين.                                                                  |
| بنود الميزانية             | BudgetLines               | LineID         | BudgetID → Budgets.BudgetID, AccountID → Accounts.AccountID                                                   | تفاصيل تخصيص الميزانيات للحسابات.                                                                        |
| التقارير الضريبية          | TaxReports                | ReportID       | -                                                                                                             | سجلات إعداد التقارير الضريبية الدورية.                                                                   |
| المستخدمون                | Users                     | UserID         | RoleID → Roles.RoleID                                                                                         | بيانات مستخدمي النظام وصلاحياتهم.                                                                         |
| الأدوار                    | Roles                     | RoleID         | -                                                                                                             | تحديد أدوار وصلاحيات المستخدمين.                                                                         |
| سجل التدقيق               | AuditLogs                 | LogID          | UserID → Users.UserID                                                                                        | تتبع نشاطات المستخدمين للتدقيق.                                                                           |

*تم توسيع نموذج البيانات ليشمل دعم تعدد العملات وربط الحسابات بالعملات، بالإضافة لجداول فئات وأنواع القيود لتصنيفها وتفريعها بدقة.*

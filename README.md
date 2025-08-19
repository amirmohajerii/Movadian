 Movadian (SDK Version)
 معرفی

این پروژه یک پیاده‌سازی کامل اتصال به سامانه مودیان با استفاده از کتابخانه رسمی .NET SDK به نام TaxCollectData.Library است.

هدف پروژه:

بارگذاری گواهی دیجیتال و کلید خصوصی

ساخت صورتحساب الکترونیکی طبق فرمت سامانه

امضا و رمزنگاری خودکار توسط SDK

ارسال به سامانه و دریافت پاسخ

استعلام وضعیت صورتحساب


نصب NuGet Package:Install-Package TaxCollectData.Library

موارد مورد نیاز :

گواهی دیجیتال (Certificate)

کلید خصوصی (Private Key)

شناسه حافظه مالیاتی (MemoryId)


 ساختار پروژه

Configuration => ورود اطلاعات پایه (گواهی، کلید، MemoryId، URL)

TaxApiManager => ساخت کلاینت ارتباط با سامانه

Models => تعریف صورتحساب (InvoiceDto, InvoiceHeaderDto, InvoiceBodyDto)

IssueInvoice => ارسال صورتحساب

InvoiceResponseModel => دریافت پاسخ و UID

GetInvoiceStatus => استعلام وضعیت با UID


مزایای استفاده از SDK

ساده‌سازی کل فرآیند

بدون نیاز به پیاده‌سازی رمزنگاری JWE و امضا

مدل‌های آماده برای صورتحساب و درخواست‌ها

مدیریت خطا و ارتباط امن به صورت داخلی

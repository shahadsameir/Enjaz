#pragma checksum "C:\Users\user\source\repos\enjaz\enjaz\Pages\Users\Employee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d2031a17352d0315cd39b0a4434a2d97ea74198"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(enjaz.Pages.Users.Pages_Users_Employee), @"mvc.1.0.razor-page", @"/Pages/Users/Employee.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Users/Employee.cshtml", typeof(enjaz.Pages.Users.Pages_Users_Employee), null)]
namespace enjaz.Pages.Users
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\user\source\repos\enjaz\enjaz\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\user\source\repos\enjaz\enjaz\Pages\_ViewImports.cshtml"
using enjaz;

#line default
#line hidden
#line 3 "C:\Users\user\source\repos\enjaz\enjaz\Pages\_ViewImports.cshtml"
using enjaz.Data;

#line default
#line hidden
#line 2 "C:\Users\user\source\repos\enjaz\enjaz\Pages\Users\Employee.cshtml"
using enjaz.Uitility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d2031a17352d0315cd39b0a4434a2d97ea74198", @"/Pages/Users/Employee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"824b2dbde4dfa3aa1bfc0cf0dee4a943b4132797", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Users_Employee : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\user\source\repos\enjaz\enjaz\Pages\Users\Employee.cshtml"
  
    ViewData["Title"] = "Employee";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(161, 168, true);
            WriteLiteral("\r\n<div>\r\n    <div class=\"row px-2 py-2\">\r\n        <div class=\"col-6\">\r\n            <h3 class=\"text-info\"> Employee</h3>\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n\r\n    <div>\r\n");
            EndContext();
#line 20 "C:\Users\user\source\repos\enjaz\enjaz\Pages\Users\Employee.cshtml"
         if (Model.Employee.Count() == 0)
        {

#line default
#line hidden
            BeginContext(383, 61, true);
            WriteLiteral("        <p>No Employee has been added! Add new Employee</p>\r\n");
            EndContext();
#line 23 "C:\Users\user\source\repos\enjaz\enjaz\Pages\Users\Employee.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(480, 176, true);
            WriteLiteral("        <table class=\"table table-striped  border-info border\">\r\n            <tr class=\"table-secondary\">\r\n                <th></th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(657, 48, false);
#line 30 "C:\Users\user\source\repos\enjaz\enjaz\Pages\Users\Employee.cshtml"
               Write(Html.DisplayNameFor(m => m.Employee[0].UserName));

#line default
#line hidden
            EndContext();
            BeginContext(705, 69, true);
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(775, 45, false);
#line 34 "C:\Users\user\source\repos\enjaz\enjaz\Pages\Users\Employee.cshtml"
               Write(Html.DisplayNameFor(m => m.Employee[0].Email));

#line default
#line hidden
            EndContext();
            BeginContext(820, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(888, 46, false);
#line 37 "C:\Users\user\source\repos\enjaz\enjaz\Pages\Users\Employee.cshtml"
               Write(Html.DisplayNameFor(m => m.Employee[0].Gender));

#line default
#line hidden
            EndContext();
            BeginContext(934, 69, true);
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1004, 48, false);
#line 41 "C:\Users\user\source\repos\enjaz\enjaz\Pages\Users\Employee.cshtml"
               Write(Html.DisplayNameFor(m => m.Employee[0].Birthday));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 48, true);
            WriteLiteral("\r\n                </th>\r\n\r\n\r\n            </tr>\r\n");
            EndContext();
#line 46 "C:\Users\user\source\repos\enjaz\enjaz\Pages\Users\Employee.cshtml"
             foreach (var item in Model.Employee)
                {

#line default
#line hidden
            BeginContext(1170, 52, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1222, "\"", 1249, 2);
            WriteAttributeValue("", 1228, "/images/", 1228, 8, true);
#line 50 "C:\Users\user\source\repos\enjaz\enjaz\Pages\Users\Employee.cshtml"
WriteAttributeValue("", 1236, item.ImgFile, 1236, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1250, 143, true);
            WriteLiteral(" alt=\"\" style=\"  position: relative; max-width: 70px; float: left; margin-right: 19px;\">\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1394, 35, false);
#line 53 "C:\Users\user\source\repos\enjaz\enjaz\Pages\Users\Employee.cshtml"
           Write(Html.DisplayFor(m => item.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1429, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1487, 32, false);
#line 57 "C:\Users\user\source\repos\enjaz\enjaz\Pages\Users\Employee.cshtml"
           Write(Html.DisplayFor(m => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1519, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1575, 33, false);
#line 60 "C:\Users\user\source\repos\enjaz\enjaz\Pages\Users\Employee.cshtml"
           Write(Html.DisplayFor(m => item.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1608, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1664, 35, false);
#line 63 "C:\Users\user\source\repos\enjaz\enjaz\Pages\Users\Employee.cshtml"
           Write(Html.DisplayFor(m => item.Birthday));

#line default
#line hidden
            EndContext();
            BeginContext(1699, 38, true);
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
            EndContext();
#line 67 "C:\Users\user\source\repos\enjaz\enjaz\Pages\Users\Employee.cshtml"

                }

#line default
#line hidden
            BeginContext(1758, 18, true);
            WriteLiteral("        </table>\r\n");
            EndContext();
#line 70 "C:\Users\user\source\repos\enjaz\enjaz\Pages\Users\Employee.cshtml"
        }

#line default
#line hidden
            BeginContext(1787, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<enjaz.Pages.Users.EmployeeModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<enjaz.Pages.Users.EmployeeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<enjaz.Pages.Users.EmployeeModel>)PageContext?.ViewData;
        public enjaz.Pages.Users.EmployeeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Projects_Practice\SfeAdminPortal\Views\Home\AddResourceSalaryDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbeca10ea8fbe281c64951f017a1880a5c22966c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddResourceSalaryDetails), @"mvc.1.0.view", @"/Views/Home/AddResourceSalaryDetails.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Projects_Practice\SfeAdminPortal\Views\_ViewImports.cshtml"
using SfeAdminPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects_Practice\SfeAdminPortal\Views\_ViewImports.cshtml"
using SfeAdminPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbeca10ea8fbe281c64951f017a1880a5c22966c", @"/Views/Home/AddResourceSalaryDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"494002d0b92fe043e677d2b69ed37d99585c6372", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_AddResourceSalaryDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<tbl_ResourceSalaryDetails>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("savebtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Save"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SaveResourceSalaryDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects_Practice\SfeAdminPortal\Views\Home\AddResourceSalaryDetails.cshtml"
  
    ViewData["Title"] = "AddResourceSalaryDetails";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    function updateTable(resId,monthsalary,yearlysalary,tds,epf,bonus){
        document.getElementById('txtMonthlySalary').value = monthsalary;
        document.getElementById('txtYearlySalary').value = yearlysalary;
        document.getElementById('txtTDS').value = tds;
        document.getElementById('txtEPF').value = epf;
        document.getElementById('txtBonus').value = bonus;
        document.getElementById('ResourceList').value = resId;

        document.getElementById('savebtn').style.display = 'none';
        document.getElementById('updatebtn').style.display = 'block';


        return false;
    }
</script>


<h1>AddResourceSalaryDetails</h1>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbeca10ea8fbe281c64951f017a1880a5c22966c6763", async() => {
                WriteLiteral("\r\n    <table>\r\n        <tr>\r\n            <td>\r\n                Resource\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "D:\Projects_Practice\SfeAdminPortal\Views\Home\AddResourceSalaryDetails.cshtml"
           Write(Html.DropDownList("ResourceList",new SelectList(ViewBag.Resourcedetails, "ResourceID", "ResourcName"),"Please Select Resource"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </td>
        </tr>
        <tr>
            <td>
                MonthlySalary
            </td>
            <td>
                <input id=""txtMonthlySalary"" type=""text"" name=""MonthlySalary"" />
            </td>
        </tr>
        <tr>
            <td>
                YearlySalary
            </td>
            <td>
                <input id=""txtYearlySalary"" type=""text"" name=""YearlySalary"" />
            </td>
        </tr>
        <tr>
            <td>
                TDS
            </td>
            <td>
                <input id=""txtTDS"" type=""text"" name=""TDS"" />
            </td>
        </tr>
        <tr>
            <td>
                EPF
            </td>
            <td>
                <input id=""txtEPF"" type=""text"" name=""EPF"" />
            </td>
        </tr>
        <tr>
            <td>
                Bonus
            </td>
            <td>
                <input id=""txtBonus"" type=""text"" name=""Bonus"" />
            </td>
        </");
                WriteLiteral("tr>\r\n        <tr>\r\n            <td>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fbeca10ea8fbe281c64951f017a1880a5c22966c8649", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <input id=""updatebtn"" type=""submit"" value=""UpdateRecord"" style=""display:none"" />
            </td>

        </tr>
    </table>

    <hr />

    <table style=""align-content:center;border-block-style:solid;width:30%; "" border=""1"">
        <th>
            ResourceID
        </th>
        <th>
            MonthlySalary
        </th>
        <th>
            Yearlysalay
        </th>
        <th>
            TDS
        </th>
        <th>
            EPF
        </th>
        <th>
            Bonus
        </th>
        <th>
            Action
        </th>
       
");
#nullable restore
#line 111 "D:\Projects_Practice\SfeAdminPortal\Views\Home\AddResourceSalaryDetails.cshtml"
          for(int i=0;i<Model.Count;i++)
         {
        

#line default
#line hidden
#nullable disable
                WriteLiteral("         <tr>\r\n             <td>\r\n                    ");
#nullable restore
#line 116 "D:\Projects_Practice\SfeAdminPortal\Views\Home\AddResourceSalaryDetails.cshtml"
               Write(Model[i].ResourceID);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n             </td>\r\n             <td>\r\n                    ");
#nullable restore
#line 119 "D:\Projects_Practice\SfeAdminPortal\Views\Home\AddResourceSalaryDetails.cshtml"
               Write(Model[i].MonthlySalary);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n             </td>            \r\n            \r\n             <td>\r\n                    ");
#nullable restore
#line 123 "D:\Projects_Practice\SfeAdminPortal\Views\Home\AddResourceSalaryDetails.cshtml"
               Write(Model[i].YearlySalary);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n             </td>\r\n             <td>\r\n                    ");
#nullable restore
#line 126 "D:\Projects_Practice\SfeAdminPortal\Views\Home\AddResourceSalaryDetails.cshtml"
               Write(Model[i].TDS);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n             </td>\r\n             <td>\r\n                    ");
#nullable restore
#line 129 "D:\Projects_Practice\SfeAdminPortal\Views\Home\AddResourceSalaryDetails.cshtml"
               Write(Model[i].EPF);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n             </td>\r\n             <td>\r\n                    ");
#nullable restore
#line 132 "D:\Projects_Practice\SfeAdminPortal\Views\Home\AddResourceSalaryDetails.cshtml"
               Write(Model[i].Bonus);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n             </td> \r\n             <td>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 3563, "\"", 3570, 0);
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 3571, "\"", 3714, 14);
                WriteAttributeValue("", 3581, "return", 3581, 6, true);
                WriteAttributeValue(" ", 3587, "updateTable(", 3588, 13, true);
#nullable restore
#line 135 "D:\Projects_Practice\SfeAdminPortal\Views\Home\AddResourceSalaryDetails.cshtml"
WriteAttributeValue("", 3600, Model[i].ResourceID, 3600, 20, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3620, ",", 3620, 1, true);
#nullable restore
#line 135 "D:\Projects_Practice\SfeAdminPortal\Views\Home\AddResourceSalaryDetails.cshtml"
WriteAttributeValue("", 3621, Model[i].MonthlySalary, 3621, 23, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3644, ",", 3644, 1, true);
#nullable restore
#line 135 "D:\Projects_Practice\SfeAdminPortal\Views\Home\AddResourceSalaryDetails.cshtml"
WriteAttributeValue("", 3645, Model[i].YearlySalary, 3645, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3667, ",", 3667, 1, true);
#nullable restore
#line 135 "D:\Projects_Practice\SfeAdminPortal\Views\Home\AddResourceSalaryDetails.cshtml"
WriteAttributeValue("", 3668, Model[i].TDS, 3668, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3681, ",", 3681, 1, true);
#nullable restore
#line 135 "D:\Projects_Practice\SfeAdminPortal\Views\Home\AddResourceSalaryDetails.cshtml"
WriteAttributeValue(" ", 3682, Model[i].EPF, 3683, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3696, ",", 3696, 1, true);
#nullable restore
#line 135 "D:\Projects_Practice\SfeAdminPortal\Views\Home\AddResourceSalaryDetails.cshtml"
WriteAttributeValue(" ", 3697, Model[i].Bonus, 3698, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3713, ")", 3713, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Update</a>\r\n             </td>\r\n                \r\n         </tr>\r\n");
#nullable restore
#line 139 "D:\Projects_Practice\SfeAdminPortal\Views\Home\AddResourceSalaryDetails.cshtml"
         }

#line default
#line hidden
#nullable disable
                WriteLiteral("           \r\n        \r\n        \r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<tbl_ResourceSalaryDetails>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
#pragma checksum "D:\stankin\Web\FitnessCenter\FitnessCenter\Views\Center\ShowCenter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8d63e10dc9e773f999739dad1708d0d4cf1c031"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Center_ShowCenter), @"mvc.1.0.view", @"/Views/Center/ShowCenter.cshtml")]
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
#line 1 "D:\stankin\Web\FitnessCenter\FitnessCenter\Views\_ViewImports.cshtml"
using FitnessCenter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\stankin\Web\FitnessCenter\FitnessCenter\Views\_ViewImports.cshtml"
using FitnessCenter.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8d63e10dc9e773f999739dad1708d0d4cf1c031", @"/Views/Center/ShowCenter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0cf8614e64699bd01be1d4306439456f8e40e20", @"/Views/_ViewImports.cshtml")]
    public class Views_Center_ShowCenter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FitnessCenter.Models.Center>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\stankin\Web\FitnessCenter\FitnessCenter\Views\Center\ShowCenter.cshtml"
  
    ViewBag.Title = "Все пользователи";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8d63e10dc9e773f999739dad1708d0d4cf1c0313567", async() => {
                WriteLiteral("Add center");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr><td>id</td><td>Name</td><td>Adress</td><td>Phone Number</td></tr>\r\n");
#nullable restore
#line 8 "D:\stankin\Web\FitnessCenter\FitnessCenter\Views\Center\ShowCenter.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 11 "D:\stankin\Web\FitnessCenter\FitnessCenter\Views\Center\ShowCenter.cshtml"
           Write(item.CenterId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 12 "D:\stankin\Web\FitnessCenter\FitnessCenter\Views\Center\ShowCenter.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 13 "D:\stankin\Web\FitnessCenter\FitnessCenter\Views\Center\ShowCenter.cshtml"
           Write(item.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "D:\stankin\Web\FitnessCenter\FitnessCenter\Views\Center\ShowCenter.cshtml"
           Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <th><a");
            BeginWriteAttribute("href", " href=\"", 452, "\"", 494, 2);
            WriteAttributeValue("", 459, "/Center/DeleteCenter/", 459, 21, true);
#nullable restore
#line 15 "D:\stankin\Web\FitnessCenter\FitnessCenter\Views\Center\ShowCenter.cshtml"
WriteAttributeValue("", 480, item.CenterId, 480, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></th>\r\n            <th><a");
            BeginWriteAttribute("href", " href=\"", 531, "\"", 573, 2);
            WriteAttributeValue("", 538, "/Center/UpdateCenter/", 538, 21, true);
#nullable restore
#line 16 "D:\stankin\Web\FitnessCenter\FitnessCenter\Views\Center\ShowCenter.cshtml"
WriteAttributeValue("", 559, item.CenterId, 559, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update</a></th>\r\n            <th></th>\r\n        </tr>\r\n");
#nullable restore
#line 19 "D:\stankin\Web\FitnessCenter\FitnessCenter\Views\Center\ShowCenter.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FitnessCenter.Models.Center>> Html { get; private set; }
    }
}
#pragma warning restore 1591
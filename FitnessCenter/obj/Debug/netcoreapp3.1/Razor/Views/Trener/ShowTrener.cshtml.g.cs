#pragma checksum "D:\stankin\Web\FitnessCenter\FitnessCenter\Views\Trener\ShowTrener.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69a8528a95f156716be5f1a09b0766fca672a308"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trener_ShowTrener), @"mvc.1.0.view", @"/Views/Trener/ShowTrener.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69a8528a95f156716be5f1a09b0766fca672a308", @"/Views/Trener/ShowTrener.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0cf8614e64699bd01be1d4306439456f8e40e20", @"/Views/_ViewImports.cshtml")]
    public class Views_Trener_ShowTrener : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FitnessCenter.Models.Trener>>
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
#line 2 "D:\stankin\Web\FitnessCenter\FitnessCenter\Views\Trener\ShowTrener.cshtml"
  
    ViewBag.Title = "Все пользователи";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69a8528a95f156716be5f1a09b0766fca672a3083567", async() => {
                WriteLiteral("Add trener");
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
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr><td>id</td><td>FirstName</td><td>LastName</td><td>Adress</td><td>CenterId</td></tr>\r\n");
#nullable restore
#line 8 "D:\stankin\Web\FitnessCenter\FitnessCenter\Views\Trener\ShowTrener.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 11 "D:\stankin\Web\FitnessCenter\FitnessCenter\Views\Trener\ShowTrener.cshtml"
           Write(item.TrenerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 12 "D:\stankin\Web\FitnessCenter\FitnessCenter\Views\Trener\ShowTrener.cshtml"
           Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 13 "D:\stankin\Web\FitnessCenter\FitnessCenter\Views\Trener\ShowTrener.cshtml"
           Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<td>\r\n            <td>");
#nullable restore
#line 14 "D:\stankin\Web\FitnessCenter\FitnessCenter\Views\Trener\ShowTrener.cshtml"
           Write(item.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "D:\stankin\Web\FitnessCenter\FitnessCenter\Views\Trener\ShowTrener.cshtml"
           Write(item.CenterId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <th><a");
            BeginWriteAttribute("href", " href=\"", 508, "\"", 550, 2);
            WriteAttributeValue("", 515, "/Trener/DeleteTrener/", 515, 21, true);
#nullable restore
#line 16 "D:\stankin\Web\FitnessCenter\FitnessCenter\Views\Trener\ShowTrener.cshtml"
WriteAttributeValue("", 536, item.TrenerId, 536, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></th>\r\n            <th><a");
            BeginWriteAttribute("href", " href=\"", 587, "\"", 629, 2);
            WriteAttributeValue("", 594, "/Trener/UpdateTrener/", 594, 21, true);
#nullable restore
#line 17 "D:\stankin\Web\FitnessCenter\FitnessCenter\Views\Trener\ShowTrener.cshtml"
WriteAttributeValue("", 615, item.TrenerId, 615, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update</a></th>\r\n            <th></th>\r\n        </tr>\r\n");
#nullable restore
#line 20 "D:\stankin\Web\FitnessCenter\FitnessCenter\Views\Trener\ShowTrener.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FitnessCenter.Models.Trener>> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\Rusik\source\repos\BusinessGarant\BusinessGarant\Views\Home\SuccessView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a507af956c7c658b619b542f55672b3e7616cd02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SuccessView), @"mvc.1.0.view", @"/Views/Home/SuccessView.cshtml")]
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
#line 1 "C:\Users\Rusik\source\repos\BusinessGarant\BusinessGarant\Views\_ViewImports.cshtml"
using BusinessGarant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rusik\source\repos\BusinessGarant\BusinessGarant\Views\_ViewImports.cshtml"
using BusinessGarant.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a507af956c7c658b619b542f55672b3e7616cd02", @"/Views/Home/SuccessView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"887e4147545aa76f46df470761b3ec3b99a69ab3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SuccessView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""myModal"" class=""modal fade"">
    <div class=""modal-dialog modal-confirm"">
        <div class=""modal-content"">
            <div class=""modal-header justify-content-center"">
                <div class=""icon-box"">
                    <i class=""material-icons"">&#xE876;</i>
                </div>
                <button type=""button"" class=""close"" data-toggle=""myModal"" onclick=""removeGood()"" aria-hidden=""true""><span aria-hidden=""true"">&times;</span></button>
            </div>
            <div class=""modal-body text-center"">
                <h4>");
#nullable restore
#line 11 "C:\Users\Rusik\source\repos\BusinessGarant\BusinessGarant\Views\Home\SuccessView.cshtml"
               Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p></p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

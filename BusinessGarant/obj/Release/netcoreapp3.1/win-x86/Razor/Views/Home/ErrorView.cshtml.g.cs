#pragma checksum "C:\Users\Rusik\source\repos\BusinessGarant\BusinessGarant\Views\Home\ErrorView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3a054b3da02b7c60a2d2d10df31972834dd9075"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ErrorView), @"mvc.1.0.view", @"/Views/Home/ErrorView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3a054b3da02b7c60a2d2d10df31972834dd9075", @"/Views/Home/ErrorView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"887e4147545aa76f46df470761b3ec3b99a69ab3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ErrorView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""bad"" class=""modal fade"">
    <div class=""modal-dialog modal-confirm bad"">
        <div class=""modal-content bad"">
            <div class=""modal-header bad justify-content-center"" style="" background: #c94747"">
                <div class=""icon-box"">
                    <i class=""material-icons"">&#xE5CD;</i>
                </div>
                <button type=""button"" class=""close"" onclick=""removeBad()"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
            </div>
            <div class=""modal-body text-center"">
                <h4>Упс!</h4>
                <p>Щось пішло не так.</p>
                <button class=""btn btn-success"" onclick=""removeBad()"" data-dismiss=""modal"">Попробуйте знову</button>
            </div>
        </div>
    </div>
</div>");
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

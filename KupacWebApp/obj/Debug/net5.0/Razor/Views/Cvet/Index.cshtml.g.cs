#pragma checksum "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Cvet\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb0c87f02f6dfbe5f5c02136db52552ca3cd49f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cvet_Index), @"mvc.1.0.view", @"/Views/Cvet/Index.cshtml")]
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
#line 1 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\_ViewImports.cshtml"
using KupacWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\_ViewImports.cshtml"
using KupacWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Cvet\Index.cshtml"
using Domen;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb0c87f02f6dfbe5f5c02136db52552ca3cd49f8", @"/Views/Cvet/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7215fd201eb55973eb3591b8a0d49a1b4b9bc775", @"/Views/_ViewImports.cshtml")]
    public class Views_Cvet_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CvetViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("position:center; border: double;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"modal fade\" id=\"infoCvet\">\r\n    <div class=\"modal-dialog\">\r\n        <div class=\"modal-content\">\r\n            <div style=\"background-color:#ef9f9f\" class=\"modal-header\">\r\n                <h6 class=\"modal-title\">");
#nullable restore
#line 8 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Cvet\Index.cshtml"
                                   Write(Model.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                <button type=""button"" class=""close"" data-dismiss=""modal""><span>x</span></button>
            </div>
            <div class=""modal-body"" style=""display:inline-flex"">
                <div class=""rounded"" style=""border:double; width:50%"">
                    <div class=""rounded"" style=""border-bottom:double; margin-left:0;margin-right:0"">
                        <label>Familija: ");
#nullable restore
#line 14 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Cvet\Index.cshtml"
                                    Write(Model.Familija);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </div>\r\n                    <div class=\"rounded\" style=\"border-bottom: double; margin-left: 0; margin-right: 0\">\r\n                        <label>Boja: ");
#nullable restore
#line 17 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Cvet\Index.cshtml"
                                Write(Model.Boja);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </div>\r\n                    <div class=\"rounded\" style=\"border-bottom: double; margin-left: 0; margin-right: 0\">\r\n                        <label>Cena: ");
#nullable restore
#line 20 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Cvet\Index.cshtml"
                                Write(Model.Cena);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </div>\r\n                    <div class=\"rounded\" style=\"margin-left: 0; margin-right: 0\">\r\n                        <label>Opis: ");
#nullable restore
#line 23 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Cvet\Index.cshtml"
                                Write(Model.Opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </div>\r\n                </div>\r\n                <div style=\"margin-left:8px; width:50%\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bb0c87f02f6dfbe5f5c02136db52552ca3cd49f86666", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Cvet\Index.cshtml"
                                                                                      WriteLiteral("~/slike/"+Model.Slika);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 27 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Cvet\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CvetViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

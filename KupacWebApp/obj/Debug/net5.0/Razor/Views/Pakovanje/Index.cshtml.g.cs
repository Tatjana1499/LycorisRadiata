#pragma checksum "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Pakovanje\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74591e60d27f49d80501a0e534a3832ad0925b42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pakovanje_Index), @"mvc.1.0.view", @"/Views/Pakovanje/Index.cshtml")]
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
#line 1 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Pakovanje\Index.cshtml"
using Domen;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74591e60d27f49d80501a0e534a3832ad0925b42", @"/Views/Pakovanje/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7215fd201eb55973eb3591b8a0d49a1b4b9bc775", @"/Views/_ViewImports.cshtml")]
    public class Views_Pakovanje_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PakovanjeViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""modal fade"" id=""infoPakovanje"" >
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div style=""background-color:#ef9f9f"" class=""modal-header"">
                <h6 class=""modal-title"">Detalji</h6>
                <button type=""button"" class=""close"" data-dismiss=""modal""><span>x</span></button>
            </div>
            <div class=""pre-scrollable"">
");
#nullable restore
#line 12 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Pakovanje\Index.cshtml"
                 foreach (PakovanjeViewModel item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""modal-body"" style=""display:inline-flex;"">
                    <div style=""width: 50%; border: double;"">
                        <div style=""border-bottom:double; margin-left: 0; margin-right: 0"">
                            <label>Naziv: ");
#nullable restore
#line 17 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Pakovanje\Index.cshtml"
                                     Write(item.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                        <div style=\"border-bottom:double; margin-left:0;margin-right:0\">\r\n                            <label>Materijal: ");
#nullable restore
#line 20 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Pakovanje\Index.cshtml"
                                         Write(item.Materijal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                        <div style=\"border-bottom: double; margin-left: 0; margin-right: 0\">\r\n                            <label>Boja: ");
#nullable restore
#line 23 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Pakovanje\Index.cshtml"
                                    Write(item.Boja);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                        <div style=\"border-bottom: double; margin-left: 0; margin-right: 0\">\r\n                            <label>Oblik: ");
#nullable restore
#line 26 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Pakovanje\Index.cshtml"
                                     Write(item.Oblik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                        <div style=\"margin-left: 0; margin-right: 0\">\r\n                            <label>Cena: ");
#nullable restore
#line 29 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Pakovanje\Index.cshtml"
                                    Write(item.Cena);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n                    </div>\r\n                    <div style=\"border:double; width:50%\">\r\n                        <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 1720, "\"", 1737, 1);
#nullable restore
#line 33 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Pakovanje\Index.cshtml"
WriteAttributeValue("", 1726, item.Slika, 1726, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 36 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Pakovanje\Index.cshtml"
                   
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PakovanjeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
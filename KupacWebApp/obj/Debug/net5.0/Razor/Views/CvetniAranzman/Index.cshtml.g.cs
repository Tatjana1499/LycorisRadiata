#pragma checksum "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\CvetniAranzman\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f480c4bae517678a16a0ac13cab7707dd97d7478"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CvetniAranzman_Index), @"mvc.1.0.view", @"/Views/CvetniAranzman/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f480c4bae517678a16a0ac13cab7707dd97d7478", @"/Views/CvetniAranzman/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7215fd201eb55973eb3591b8a0d49a1b4b9bc775", @"/Views/_ViewImports.cshtml")]
    public class Views_CvetniAranzman_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CvetniAranzmanViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    \r\n    <div style=\"max-height:600px; overflow-y:scroll\">\r\n");
#nullable restore
#line 4 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\CvetniAranzman\Index.cshtml"
         foreach (CvetniAranzmanViewModel item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""list-group-item rounded-pill"" style=""border-style: solid; border-width: medium; border-color: brown; margin: 30px;padding-left:150px; background-repeat: no-repeat;background-size:auto 100%;background-position-x:right; background-image: url(../slike/okvir7.jpg) "">
                <div class=""toast-header font-weight-bolder rounded-pill"" style=""width:55%; background-color:#c27474; margin-top:30px"">
                    <h4 style=""text-align: center;"" class=""text-dark"">Naziv: ");
#nullable restore
#line 8 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\CvetniAranzman\Index.cshtml"
                                                                        Write(item.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n                <div style=\"width:70%; padding-bottom:30px\">\r\n                    <div style=\"margin-top:10px\">\r\n");
#nullable restore
#line 12 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\CvetniAranzman\Index.cshtml"
                         if (item.Masna)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label>Mašna: Da</label>\r\n");
#nullable restore
#line 15 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\CvetniAranzman\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label>Mašna: Ne</label>\r\n");
#nullable restore
#line 19 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\CvetniAranzman\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div>\r\n                        <label>Sjaj: ");
#nullable restore
#line 22 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\CvetniAranzman\Index.cshtml"
                                Write(item.Sjaj.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </div>\r\n                    <div>\r\n                        <label>Pakovanje: ");
#nullable restore
#line 25 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\CvetniAranzman\Index.cshtml"
                                     Write(item.Pakovanje.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </div>\r\n                    <div>\r\n                        <label>Namena: ");
#nullable restore
#line 28 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\CvetniAranzman\Index.cshtml"
                                  Write(item.Namena.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </div>\r\n\r\n                    <div class=\"flex-sm-wrap\">\r\n                        <label class=\"flex-sm-wrap\">Napomena: ");
#nullable restore
#line 32 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\CvetniAranzman\Index.cshtml"
                                                         Write(item.Napomena);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </div>\r\n                    <div>\r\n                        <label>Cveće: </label>\r\n");
#nullable restore
#line 36 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\CvetniAranzman\Index.cshtml"
                         foreach (string cvet in item.Cvece)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <ul>");
#nullable restore
#line 38 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\CvetniAranzman\Index.cshtml"
                           Write(cvet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
#nullable restore
#line 39 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\CvetniAranzman\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 43 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\CvetniAranzman\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CvetniAranzmanViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

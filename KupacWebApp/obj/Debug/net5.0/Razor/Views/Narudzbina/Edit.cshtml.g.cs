#pragma checksum "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebf204a43f6827720bc81a35e7c8087d83de14a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Narudzbina_Edit), @"mvc.1.0.view", @"/Views/Narudzbina/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebf204a43f6827720bc81a35e7c8087d83de14a0", @"/Views/Narudzbina/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7215fd201eb55973eb3591b8a0d49a1b4b9bc775", @"/Views/_ViewImports.cshtml")]
    public class Views_Narudzbina_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NarudzbinaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div style=\"max-height:600px; overflow-y:scroll; font-family:\'Franklin Gothic Medium\', \'Arial Narrow\', Arial, sans-serif\" class=\"text-dark\">\r\n");
#nullable restore
#line 4 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
     foreach (NarudzbinaViewModel item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""list-group-item rounded-pill"" style=""border-style: solid; border-width: medium; border-color: brown; margin: 30px;padding-left:150px; background-repeat: no-repeat;background-size:auto 100%;background-position-x:right; background-image: url(../slike/okvir7.jpg) "">
            <div style=""width:70%; padding-bottom:30px"">
                <div style=""margin-top:10px;"">
                    <label>Kupac: ");
#nullable restore
#line 9 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                             Write(item.Kupac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\r\n                </div>\r\n                <div>\r\n                    <label>Status isporuke: ");
#nullable restore
#line 13 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                                       Write(item.StatusIsporuke);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n                <div>\r\n                    <label>Vrsta narudzbine: ");
#nullable restore
#line 16 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                                        Write(item.VrstaNarudzbine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n");
#nullable restore
#line 18 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                 if (item.VrstaNarudzbine == Domen.VrstaNarudzbine.Dostava)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <label>Adresa: ");
#nullable restore
#line 21 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                                  Write(item.Adresa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </div>\r\n");
#nullable restore
#line 23 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <label>Adresa prodajnog mesta: ");
#nullable restore
#line 27 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                                                  Write(item.ProdajnoMesto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </div>\r\n");
#nullable restore
#line 29 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"display:inline-flex\">\r\n                    Stavke: &nbsp\r\n");
#nullable restore
#line 32 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                     foreach (var stavka in item.Stavke)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label>  [");
#nullable restore
#line 34 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                             Write(stavka);

#line default
#line hidden
#nullable disable
            WriteLiteral("] &nbsp </label>\r\n");
#nullable restore
#line 35 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <div style=""margin-top:10px"">
                    
                    <button type=""button"" style=""margin-left:100px;"" class=""btn btn-primary btn-outline-dark"" data-toggle=""ajax-modal"" data-target=""#infoCvet"" data-url=""");
#nullable restore
#line 39 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                                                                                                                                                                    Write(Url.Action("IzmeniStatus","Narudzbina",new { id = item.NarudzbinaId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Izmeni status</button>\r\n                    <button style=\"margin-left: 10px; display:inline \" class=\"btn btn-primary btn-outline-dark\">Izbriši</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 44 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NarudzbinaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

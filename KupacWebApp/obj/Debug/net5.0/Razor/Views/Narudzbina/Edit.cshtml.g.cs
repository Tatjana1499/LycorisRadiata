#pragma checksum "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "867395c406108380f45066e29e0f8ec0859b86b5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"867395c406108380f45066e29e0f8ec0859b86b5", @"/Views/Narudzbina/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7215fd201eb55973eb3591b8a0d49a1b4b9bc775", @"/Views/_ViewImports.cshtml")]
    public class Views_Narudzbina_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NarudzbinaViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-pill form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align:center; margin-right:10px; width:300px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
 if (Model is null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""list-group-item rounded-pill"" style=""border-style: solid; border-width: medium; border-color: brown; margin: 30px;padding-left:80px;margin-top:100px"">
        <h1 class=""font-weight-bolder text-center font-italic"">Tra??eni kupac ne postoji.</h1>
        <p class=""font-weight-normal text-center"">(Proveri ispravnost unosa korisni??kog imena)</p>
    </div>
");
#nullable restore
#line 9 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
}
else if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""list-group-item rounded-pill"" style=""border-style: solid; border-width: medium; border-color: brown; margin: 30px;padding-left:80px;margin-top:100px"">
        <h1 class=""font-weight-bolder text-center font-italic"">Kupac nema narud??bine.</h1>
    </div>
");
#nullable restore
#line 15 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"max-height:600px; overflow-y:scroll; font-family:\'Franklin Gothic Medium\', \'Arial Narrow\', Arial, sans-serif\" class=\"text-dark\">\r\n\r\n");
#nullable restore
#line 20 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
         foreach (NarudzbinaViewModel item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("id", " id=\"", 982, "\"", 1016, 2);
            WriteAttributeValue("", 987, "narudzbina", 987, 10, true);
#nullable restore
#line 22 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
WriteAttributeValue(" ", 997, item.NarudzbinaId, 998, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""list-group-item rounded-pill"" style=""border-style: solid; border-width: medium; border-color: brown; margin: 30px;padding-left:150px; background-repeat: no-repeat;background-size:auto 100%;background-position-x:right; background-image: url(../slike/okvir7.jpg) "">

                <div style=""width:70%; padding-bottom:30px"">
                    <div style=""margin-top:10px;"">
                        <label>Kupac: ");
#nullable restore
#line 26 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                                 Write(item.Kupac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\r\n                    </div>\r\n                    <div style=\"display:inline-flex\">\r\n                        <label");
            BeginWriteAttribute("id", " id=\"", 1580, "\"", 1607, 2);
            WriteAttributeValue("", 1585, "lbl", 1585, 3, true);
#nullable restore
#line 30 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
WriteAttributeValue(" ", 1588, item.NarudzbinaId, 1589, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Status isporuke: </label>\r\n                        <p");
            BeginWriteAttribute("id", " id=\"", 1662, "\"", 1687, 2);
            WriteAttributeValue("", 1667, "p", 1667, 1, true);
#nullable restore
#line 31 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
WriteAttributeValue(" ", 1668, item.NarudzbinaId, 1669, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                                                Write(item.StatusIsporuke);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        \r\n                    </div>\r\n                    <div>\r\n                        <label>Vrsta narudzbine: ");
#nullable restore
#line 35 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                                            Write(item.VrstaNarudzbine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </div>\r\n");
#nullable restore
#line 37 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                     if (item.VrstaNarudzbine == Domen.VrstaNarudzbine.Dostava)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>\r\n                            <label>Adresa: ");
#nullable restore
#line 40 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                                      Write(item.Adresa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n");
#nullable restore
#line 42 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>\r\n                            <label>Adresa prodajnog mesta: ");
#nullable restore
#line 46 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                                                      Write(item.ProdajnoMesto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n");
#nullable restore
#line 48 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div style=\"display:block\">\r\n                        Stavke: &nbsp\r\n");
#nullable restore
#line 51 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                         foreach (var stavka in item.Stavke)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label>  [");
#nullable restore
#line 53 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                                 Write(stavka);

#line default
#line hidden
#nullable disable
            WriteLiteral("] &nbsp </label>\r\n");
#nullable restore
#line 54 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n\r\n                    <div style=\"margin-top:10px; display:inline-flex\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "867395c406108380f45066e29e0f8ec0859b86b511384", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2787, "slc", 2787, 3, true);
#nullable restore
#line 58 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
AddHtmlAttributeValue(" ", 2790, item.NarudzbinaId, 2791, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 58 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Html.GetEnumSelectList<Domen.StatusIsporuke>();

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n\r\n\r\n                        <button");
            BeginWriteAttribute("value", " value=\"", 3009, "\"", 3035, 1);
#nullable restore
#line 61 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
WriteAttributeValue("", 3017, item.NarudzbinaId, 3017, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" style=\"margin-left:10px;\" class=\"izmeni btn btn-primary btn-outline-dark\"");
            BeginWriteAttribute("id", " id=\"", 3124, "\"", 3151, 2);
            WriteAttributeValue("", 3129, "btn", 3129, 3, true);
#nullable restore
#line 61 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
WriteAttributeValue(" ", 3132, item.NarudzbinaId, 3133, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Izmeni status</button>\r\n\r\n");
#nullable restore
#line 63 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                         if (item.StatusIsporuke == Domen.StatusIsporuke.Zastarelo)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button");
            BeginWriteAttribute("value", " value=\"", 3326, "\"", 3352, 1);
#nullable restore
#line 65 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
WriteAttributeValue("", 3334, item.NarudzbinaId, 3334, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 3353, "\"", 3380, 2);
            WriteAttributeValue("", 3358, "izb", 3358, 3, true);
#nullable restore
#line 65 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
WriteAttributeValue(" ", 3361, item.NarudzbinaId, 3362, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-left: 10px; display:inline \" class=\"izbrisi btn btn-primary btn-outline-dark\">Izbri??i</button>\r\n");
#nullable restore
#line 66 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button");
            BeginWriteAttribute("value", " value=\"", 3611, "\"", 3637, 1);
#nullable restore
#line 69 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
WriteAttributeValue("", 3619, item.NarudzbinaId, 3619, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden");
            BeginWriteAttribute("id", " id=\"", 3645, "\"", 3672, 2);
            WriteAttributeValue("", 3650, "izb", 3650, 3, true);
#nullable restore
#line 69 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
WriteAttributeValue(" ", 3653, item.NarudzbinaId, 3654, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-left: 10px; display:inline \" class=\"izbrisi btn btn-primary btn-outline-dark\">Izbri??i</button>\r\n");
#nullable restore
#line 70 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n");
#nullable restore
#line 76 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 79 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n        $(\".izmeni\").click(function () {\r\n\r\n\r\n            var yourSelect = document.getElementById(\"slc \" + $(this).val());\r\n            var id = $(this).val()\r\n\r\n        $.ajax({\r\n            url: \"");
#nullable restore
#line 91 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
             Write(Url.Action("IzmeniStatus", "Narudzbina"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
            method: ""post"",
            data: { id: $(this).val(), StatusIsporuke: yourSelect.options[yourSelect.selectedIndex].value },
            success: function (data) {
                if (data === ""greska"") {
                    alert(""Desila se gre??ka"");
                }
                else if (data === ""Zastarelo"") {
                    document.getElementById(""p "" + id).innerHTML = "" "" + data;
                    document.getElementById(""izb "" + id).hidden = false;
                }
                else {
                    document.getElementById(""p "" + id).innerHTML = "" "" + data
                    document.getElementById(""izb "" + id).hidden = true;
                }
            },
        })
        })

        $("".izbrisi"").click(function () {

            var id = $(this).val()

        $.ajax({
            url: """);
#nullable restore
#line 115 "C:\Users\Tatjana Bailovic\source\repos\LycorisRadiata\KupacWebApp\Views\Narudzbina\Edit.cshtml"
             Write(Url.Action("Izbrisi", "Narudzbina"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
            method: ""delete"",
            data: { id: $(this).val() },
            success: function (data) {
                if (data === ""greska"") {
                    alert(""Desila se gre??ka."");
                    document.getElementById(""narudzbina "" + id).hidden = false;
                }
                else {
                    alert(""Uspesno obrisana narud??bina."");
                    document.getElementById(""narudzbina "" + id).hidden = true;
                }
            }
        })
        })


    </script>
");
            }
            );
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

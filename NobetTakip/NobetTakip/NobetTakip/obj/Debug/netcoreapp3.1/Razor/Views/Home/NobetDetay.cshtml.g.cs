#pragma checksum "C:\Users\yusuf\OneDrive\Masaüstü\GitHub\NobetTakip\NobetTakip\NobetTakip\NobetTakip\Views\Home\NobetDetay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81e7a03d06a9e8daa58959e53076fc2a7375ee14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NobetDetay), @"mvc.1.0.view", @"/Views/Home/NobetDetay.cshtml")]
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
#line 1 "C:\Users\yusuf\OneDrive\Masaüstü\GitHub\NobetTakip\NobetTakip\NobetTakip\NobetTakip\Views\_ViewImports.cshtml"
using NobetTakip;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yusuf\OneDrive\Masaüstü\GitHub\NobetTakip\NobetTakip\NobetTakip\NobetTakip\Views\_ViewImports.cshtml"
using NobetTakip.Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81e7a03d06a9e8daa58959e53076fc2a7375ee14", @"/Views/Home/NobetDetay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1cb3810195ec3bb7906cbec3f84a26e880829c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NobetDetay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NobetTakip.Core.Models.Nobet>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\yusuf\OneDrive\Masaüstü\GitHub\NobetTakip\NobetTakip\NobetTakip\NobetTakip\Views\Home\NobetDetay.cshtml"
  
    ViewData["Title"] = "Nöbet Bilgileri " + Model.NobetId;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"section-header mt-40\">Nöbet Bilgileri</div>\r\n\r\n<div class=\"nobet-data\">\r\n");
#nullable restore
#line 9 "C:\Users\yusuf\OneDrive\Masaüstü\GitHub\NobetTakip\NobetTakip\NobetTakip\NobetTakip\Views\Home\NobetDetay.cshtml"
     if (Model.DayNight == false)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""info-row timepill day"">
            <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 20 20"" fill=""currentColor"">
                <path fill-rule=""evenodd"" d=""M10 2a1 1 0 011 1v1a1 1 0 11-2 0V3a1 1 0 011-1zm4 8a4 4 0 11-8 0 4 4 0 018 0zm-.464 4.95l.707.707a1 1 0 001.414-1.414l-.707-.707a1 1 0 00-1.414 1.414zm2.12-10.607a1 1 0 010 1.414l-.706.707a1 1 0 11-1.414-1.414l.707-.707a1 1 0 011.414 0zM17 11a1 1 0 100-2h-1a1 1 0 100 2h1zm-7 4a1 1 0 011 1v1a1 1 0 11-2 0v-1a1 1 0 011-1zM5.05 6.464A1 1 0 106.465 5.05l-.708-.707a1 1 0 00-1.414 1.414l.707.707zm1.414 8.486l-.707.707a1 1 0 01-1.414-1.414l.707-.707a1 1 0 011.414 1.414zM4 11a1 1 0 100-2H3a1 1 0 000 2h1z"" clip-rule=""evenodd"" />
            </svg>
            <p>GÜNDÜZ</p>
        </div>
");
#nullable restore
#line 17 "C:\Users\yusuf\OneDrive\Masaüstü\GitHub\NobetTakip\NobetTakip\NobetTakip\NobetTakip\Views\Home\NobetDetay.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""info-row timepill night"">
            <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 20 20"" fill=""currentColor"">
                <path d=""M17.293 13.293A8 8 0 016.707 2.707a8.001 8.001 0 1010.586 10.586z"" />
            </svg>
            <p>GECE</p>
        </div>
");
#nullable restore
#line 26 "C:\Users\yusuf\OneDrive\Masaüstü\GitHub\NobetTakip\NobetTakip\NobetTakip\NobetTakip\Views\Home\NobetDetay.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""info-row title"">
        <svg xmlns=""http://www.w3.org/2000/svg"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"">
            <path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M8 7V3m8 4V3m-9 8h10M5 21h14a2 2 0 002-2V7a2 2 0 00-2-2H5a2 2 0 00-2 2v12a2 2 0 002 2z"" />
        </svg>
        <p>");
#nullable restore
#line 31 "C:\Users\yusuf\OneDrive\Masaüstü\GitHub\NobetTakip\NobetTakip\NobetTakip\NobetTakip\Views\Home\NobetDetay.cshtml"
      Write(Model.Date.ToString("dd MMMM dddd"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
    </div>
    <div class=""info-row title"">
        <svg xmlns=""http://www.w3.org/2000/svg"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"">
            <path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M12 8v4l3 3m6-3a9 9 0 11-18 0 9 9 0 0118 0z"" />
        </svg>
");
#nullable restore
#line 37 "C:\Users\yusuf\OneDrive\Masaüstü\GitHub\NobetTakip\NobetTakip\NobetTakip\NobetTakip\Views\Home\NobetDetay.cshtml"
         if (Model.Type == 1 && Model.Period == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>08:00 - 20:00</p>\r\n");
#nullable restore
#line 40 "C:\Users\yusuf\OneDrive\Masaüstü\GitHub\NobetTakip\NobetTakip\NobetTakip\NobetTakip\Views\Home\NobetDetay.cshtml"
        }
        else if (Model.Type == 1 && Model.Period == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>20:00 - 08:00</p>\r\n");
#nullable restore
#line 44 "C:\Users\yusuf\OneDrive\Masaüstü\GitHub\NobetTakip\NobetTakip\NobetTakip\NobetTakip\Views\Home\NobetDetay.cshtml"
        }
        else if (Model.Type == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>24 Saat Nöbeti</p>\r\n");
#nullable restore
#line 48 "C:\Users\yusuf\OneDrive\Masaüstü\GitHub\NobetTakip\NobetTakip\NobetTakip\NobetTakip\Views\Home\NobetDetay.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"section-header mt-40\">Nöbetteki Kişiler</div>\r\n\r\n<div class=\"nobet-data\">\r\n\r\n");
#nullable restore
#line 57 "C:\Users\yusuf\OneDrive\Masaüstü\GitHub\NobetTakip\NobetTakip\NobetTakip\NobetTakip\Views\Home\NobetDetay.cshtml"
     for(int i = 0; i < Model.Nobetciler.Count; i++)
    { NobetTakip.Core.Models.Personel p = Model.Nobetciler[i];
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""info-row title"">
        <svg xmlns=""http://www.w3.org/2000/svg"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"">
            <path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M16 7a4 4 0 11-8 0 4 4 0 018 0zM12 14a7 7 0 00-7 7h14a7 7 0 00-7-7z"" />
        </svg>
        <p>");
#nullable restore
#line 64 "C:\Users\yusuf\OneDrive\Masaüstü\GitHub\NobetTakip\NobetTakip\NobetTakip\NobetTakip\Views\Home\NobetDetay.cshtml"
      Write(p.RealName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 65 "C:\Users\yusuf\OneDrive\Masaüstü\GitHub\NobetTakip\NobetTakip\NobetTakip\NobetTakip\Views\Home\NobetDetay.cshtml"
         if (i > 0)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"button\" class=\"btn-flat svg-button\" data-nobetcino=\"");
#nullable restore
#line 68 "C:\Users\yusuf\OneDrive\Masaüstü\GitHub\NobetTakip\NobetTakip\NobetTakip\NobetTakip\Views\Home\NobetDetay.cshtml"
                                                                 Write(p.PersonelId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-nobetciad=\"");
#nullable restore
#line 68 "C:\Users\yusuf\OneDrive\Masaüstü\GitHub\NobetTakip\NobetTakip\NobetTakip\NobetTakip\Views\Home\NobetDetay.cshtml"
                                                                                                Write(p.RealName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-bs-toggle=""modal"" data-bs-target=""#modalNobetDegisim"">
        <svg class=""action"" xmlns=""http://www.w3.org/2000/svg"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"">
            <path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M8 7h12m0 0l-4-4m4 4l-4 4m0 6H4m0 0l4 4m-4-4l4-4"" />
        </svg>
    </button>
");
#nullable restore
#line 73 "C:\Users\yusuf\OneDrive\Masaüstü\GitHub\NobetTakip\NobetTakip\NobetTakip\NobetTakip\Views\Home\NobetDetay.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 75 "C:\Users\yusuf\OneDrive\Masaüstü\GitHub\NobetTakip\NobetTakip\NobetTakip\NobetTakip\Views\Home\NobetDetay.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>


<div class=""section-header mt-40"">Nöbet İşlemleri</div>
<div class=""nobet-data"">
    <div class=""info-row title"">
        <a href=""/nobet/takvim"">
            <svg xmlns=""http://www.w3.org/2000/svg"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"">
                <path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M15 17h5l-1.405-1.405A2.032 2.032 0 0118 14.158V11a6.002 6.002 0 00-4-5.659V5a2 2 0 10-4 0v.341C7.67 6.165 6 8.388 6 11v3.159c0 .538-.214 1.055-.595 1.436L4 17h5m6 0v1a3 3 0 11-6 0v-1m6 0H9"" />
            </svg>
            <p>Alarm Oluştur</p>
        </a>
    </div>
    <div class=""info-row title"">
        <a");
            BeginWriteAttribute("href", " href=\"", 4120, "\"", 4164, 2);
            WriteAttributeValue("", 4127, "whatsapp://send?text=", 4127, 21, true);
#nullable restore
#line 90 "C:\Users\yusuf\OneDrive\Masaüstü\GitHub\NobetTakip\NobetTakip\NobetTakip\NobetTakip\Views\Home\NobetDetay.cshtml"
WriteAttributeValue("", 4148, Model.ShareText, 4148, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" data-action=""share/whatsapp/share"">
            <svg xmlns=""http://www.w3.org/2000/svg"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"">
                <path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M8.684 13.342C8.886 12.938 9 12.482 9 12c0-.482-.114-.938-.316-1.342m0 2.684a3 3 0 110-2.684m0 2.684l6.632 3.316m-6.632-6l6.632-3.316m0 0a3 3 0 105.367-2.684 3 3 0 00-5.367 2.684zm0 9.316a3 3 0 105.368 2.684 3 3 0 00-5.368-2.684z"" />
            </svg>
            <p>Nöbet Bilgilerini Paylaş</p>
        </a>
    </div>
</div>

<div class=""modal"" id=""modalNobetDegisim"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-sm modal-dialog-centered"">
        <div class=""modal-content nd-request"">
            <div class=""modal-body"">
                <div>
                    <h5 id=""nobetMesaj"" class=""mb-4""></h5>
                    <select class=""form-select mb-2"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81e7a03d06a9e8daa58959e53076fc2a7375ee1412787", async() => {
                WriteLiteral("Nöbet Seçiniz");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </select>
                    <textarea placeholder=""Değişim isteğiniz ile ilgili açıklama yazabilirsiniz."" rows=""2"" class=""form-control""></textarea>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-sm btn-link"" data-bs-dismiss=""modal"">İptal Et</button>
                <button type=""button"" class=""btn btn-sm btn-danger"">GÖNDER</button>
            </div>
        </div>
    </div>
</div>

<script type=""text/javascript"">
    var modalNobetDegisim = document.getElementById('modalNobetDegisim')
    modalNobetDegisim.addEventListener('show.bs.modal', function (event) {
        var button = event.relatedTarget
        var nobetciAdi = button.getAttribute('data-nobetciad')
        var ndMsg = document.getElementById('nobetMesaj')
        ndMsg.textContent = nobetciAdi + "" ile nöbet değiştirmek üzeresiniz. Lütfen aşağıdan size ait olan bir nöbet seçiniz."";
    })
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NobetTakip.Core.Models.Nobet> Html { get; private set; }
    }
}
#pragma warning restore 1591

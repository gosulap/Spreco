#pragma checksum "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d92ba228454b17a289b5d54d3e36c8e10959a0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Callback), @"mvc.1.0.view", @"/Views/Home/Callback.cshtml")]
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
#line 1 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\_ViewImports.cshtml"
using Spreco;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\_ViewImports.cshtml"
using Spreco.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d92ba228454b17a289b5d54d3e36c8e10959a0d", @"/Views/Home/Callback.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"635cb7cf420d66608e22ad2750b52797dfbc15a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Callback : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/callback.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/callback.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
  
    ViewData["Title"] = "Callback";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7d92ba228454b17a289b5d54d3e36c8e10959a0d4448", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!--\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <ul>\r\n");
#nullable restore
#line 12 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
             foreach (var item in ViewBag.mapping)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"recent-track\">\r\n                    <a");
            BeginWriteAttribute("class", " class=", 299, "", 328, 1);
#nullable restore
#line 15 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
WriteAttributeValue("", 306, item.Key.getTrackId(), 306, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"#\">");
#nullable restore
#line 15 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
                                                        Write(item.Key.getTrackName());

#line default
#line hidden
#nullable disable
            WriteLiteral(" by ");
#nullable restore
#line 15 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
                                                                                    Write(item.Key.getArtistName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n");
#nullable restore
#line 17 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n    <div class=\"col-6\">\r\n");
#nullable restore
#line 21 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
         foreach (var item in ViewBag.mapping)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("id", " id=", 562, "", 588, 1);
#nullable restore
#line 23 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
WriteAttributeValue("", 566, item.Key.getTrackId(), 566, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <ul>\r\n");
#nullable restore
#line 25 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
                     foreach (var subItem in item.Value)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>");
#nullable restore
#line 27 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
                       Write(subItem.getTrackName());

#line default
#line hidden
#nullable disable
            WriteLiteral(" by ");
#nullable restore
#line 27 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
                                                  Write(subItem.getArtistName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 28 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n");
#nullable restore
#line 31 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>
 -->

<nav class=""navbar fixed-top navbar-custom"">
    <div class=""dropdown"">
        <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            Find Song
        </button>
        <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
");
#nullable restore
#line 42 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
             foreach(var item in ViewBag.mapping)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1345, "\"", 1377, 2);
            WriteAttributeValue("", 1352, "#", 1352, 1, true);
#nullable restore
#line 44 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
WriteAttributeValue("", 1353, item.Key.getImages()[0], 1353, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 44 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
                                                                     Write(item.Key.getTrackName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 45 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <a class=\"navbar-brand\" href=\"#\">\r\n        Export Songs as Playlist\r\n    </a>\r\n</nav>\r\n\r\n\r\n<div class=\"container-spreco\">\r\n");
#nullable restore
#line 55 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
     foreach (var item in ViewBag.mapping)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"parallax\"");
            BeginWriteAttribute("id", " id=", 1659, "", 1687, 1);
#nullable restore
#line 57 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
WriteAttributeValue("", 1663, item.Key.getImages()[0], 1663, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\r\n        <div class=\"similar-information\">\r\n            <h3>Songs similar to ");
#nullable restore
#line 59 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
                            Write(item.Key.getTrackName());

#line default
#line hidden
#nullable disable
            WriteLiteral(" by ");
#nullable restore
#line 59 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
                                                        Write(item.Key.getArtistName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <div class=\"contents\">\r\n");
#nullable restore
#line 61 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
                 for (var i = 0; i < item.Value.Count; i += 3)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\">\r\n");
#nullable restore
#line 64 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
                         if (i < item.Value.Count)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-4\">");
#nullable restore
#line 66 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
                                          Write(item.Value[i].getTrackName());

#line default
#line hidden
#nullable disable
            WriteLiteral(" by ");
#nullable restore
#line 66 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
                                                                           Write(item.Value[i].getArtistName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 67 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
                         if (i + 1 < item.Value.Count)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-4\">");
#nullable restore
#line 70 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
                                          Write(item.Value[i + 1].getTrackName());

#line default
#line hidden
#nullable disable
            WriteLiteral(" by ");
#nullable restore
#line 70 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
                                                                               Write(item.Value[i + 1].getArtistName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 71 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
                         if (i + 2 < item.Value.Count)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-4\">");
#nullable restore
#line 74 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
                                          Write(item.Value[i + 2].getTrackName());

#line default
#line hidden
#nullable disable
            WriteLiteral(" by ");
#nullable restore
#line 74 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
                                                                               Write(item.Value[i + 2].getArtistName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 75 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 77 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
#nullable restore
#line 80 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d92ba228454b17a289b5d54d3e36c8e10959a0d16357", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 84 "C:\Users\pradh\OneDrive\Documents\Spreco\Spreco\Views\Home\Callback.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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

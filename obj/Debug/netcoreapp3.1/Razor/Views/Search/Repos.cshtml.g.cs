#pragma checksum "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Repos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f948c1c6b671f1a45c3281685f01ee86f7e42ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Repos), @"mvc.1.0.view", @"/Views/Search/Repos.cshtml")]
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
#line 1 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/_ViewImports.cshtml"
using gitsearch_aspnetapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/_ViewImports.cshtml"
using gitsearch_aspnetapp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f948c1c6b671f1a45c3281685f01ee86f7e42ef", @"/Views/Search/Repos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a62d855837ed8317cef1fe8bf8dc4cded93f6b69", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Repos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReposViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Repos.cshtml"
  
	ViewData["title"] = "Repos";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Repos.cshtml"
 if (Model.Error == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"text-center\">\n\t\t<img");
            BeginWriteAttribute("src", " src=\"", 118, "\"", 137, 1);
#nullable restore
#line 8 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Repos.cshtml"
WriteAttributeValue("", 124, Model.Avatar, 124, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"200\" width=\"200\"/><br><br>\n\t\t<a");
            BeginWriteAttribute("href", " href=\"", 178, "\"", 215, 2);
            WriteAttributeValue("", 185, "https://github.com/", 185, 19, true);
#nullable restore
#line 9 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Repos.cshtml"
WriteAttributeValue("", 204, Model.User, 204, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n\t\t\t<h3>");
#nullable restore
#line 10 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Repos.cshtml"
           Write(Model.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s repositories</h3>\n\t\t</a>\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f948c1c6b671f1a45c3281685f01ee86f7e42ef5177", async() => {
                WriteLiteral("\n\t\t\t<button id=\"user\" name=\"user\"");
                BeginWriteAttribute("value", " value=\"", 340, "\"", 359, 1);
#nullable restore
#line 13 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Repos.cshtml"
WriteAttributeValue("", 348, Model.User, 348, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Go back</button>\n\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\t\t<br>\n\t\t<div class=\"row\">\n\t\t\t<div class=\"col-md-4\">\n\t\t\t\t<b>Repository name</b>\n\t\t\t</div>\n\t\t\t<div class=\"col-md-4\">\n\t\t\t\t<b>Language</b>\n\t\t\t</div>\n\t\t\t<div class=\"col-md-4\">\n\t\t\t\t<b>Description</b>\n\t\t\t</div>\n\t\t</div>\n\t\t<hr>\n");
#nullable restore
#line 28 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Repos.cshtml"
         if (Model.Repos.Count != 0)
		{
			

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Repos.cshtml"
             foreach (Newtonsoft.Json.Linq.JObject o in Model.Repos)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"row\">\n\t\t\t\t\t<div class=\"col-md-4\">\n\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 767, "\"", 788, 1);
#nullable restore
#line 34 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Repos.cshtml"
WriteAttributeValue("", 774, o["html_url"], 774, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Repos.cshtml"
                                            Write(o["name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n\t\t\t\t\t</div>\n\t\t\t\t\t<div class=\"col-md-4\">\n\t\t\t\t\t\t");
#nullable restore
#line 37 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Repos.cshtml"
                    Write(o["language"].ToString() != "" ? o["language"] : "None");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t\t</div>\n\t\t\t\t\t<div class=\"col-md-4\">\n\t\t\t\t\t\t");
#nullable restore
#line 40 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Repos.cshtml"
                    Write(o["description"].ToString() != "" ? o["description"] : "None");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t\t</div>\n\t\t\t\t</div>\n\t\t\t\t<hr>\n");
#nullable restore
#line 44 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Repos.cshtml"
			}

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Repos.cshtml"
             
		} else
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div>No public repositories</div>\n");
#nullable restore
#line 48 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Repos.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\n");
#nullable restore
#line 50 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Repos.cshtml"
} else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"text-center\">\n\t\t<h1 class=\"display-4\">");
#nullable restore
#line 53 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Repos.cshtml"
                         Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\t\t<br><h1>");
#nullable restore
#line 54 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Repos.cshtml"
           Write(Model.StatusCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\t\t<p>");
#nullable restore
#line 55 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Repos.cshtml"
      Write(Model.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\n\t\t<hr>\n\t</div>\n");
#nullable restore
#line 58 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Repos.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReposViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Following.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c51a597d4b69d4c973232ab771e677667bad8bc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Following), @"mvc.1.0.view", @"/Views/Search/Following.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c51a597d4b69d4c973232ab771e677667bad8bc1", @"/Views/Search/Following.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a62d855837ed8317cef1fe8bf8dc4cded93f6b69", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Following : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FollowingViewModel>
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
#line 2 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Following.cshtml"
  
	ViewData["title"] = $"People {Model.User} follows";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Following.cshtml"
 if (Model.Error == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"text-center\">\n\t\t<img");
            BeginWriteAttribute("src", " src=\"", 145, "\"", 164, 1);
#nullable restore
#line 8 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Following.cshtml"
WriteAttributeValue("", 151, Model.Avatar, 151, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"200\" width=\"200\"/><br><br>\n\t\t<a");
            BeginWriteAttribute("href", " href=\"", 205, "\"", 242, 2);
            WriteAttributeValue("", 212, "https://github.com/", 212, 19, true);
#nullable restore
#line 9 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Following.cshtml"
WriteAttributeValue("", 231, Model.User, 231, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n\t\t\t<h3>People ");
#nullable restore
#line 10 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Following.cshtml"
                  Write(Model.User);

#line default
#line hidden
#nullable disable
            WriteLiteral(" follows</h3>\n\t\t</a>\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c51a597d4b69d4c973232ab771e677667bad8bc15250", async() => {
                WriteLiteral("\n\t\t\t<button id=\"user\" name=\"user\"");
                BeginWriteAttribute("value", " value=\"", 367, "\"", 386, 1);
#nullable restore
#line 13 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Following.cshtml"
WriteAttributeValue("", 375, Model.User, 375, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Back to user</button>\n\t\t");
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
            WriteLiteral("\n\t\t<br>\n\t\t<hr>\n");
#nullable restore
#line 17 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Following.cshtml"
         if (Model.Following.Count != 0)
		{
			

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Following.cshtml"
             foreach (Newtonsoft.Json.Linq.JObject o in Model.Following)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c51a597d4b69d4c973232ab771e677667bad8bc17757", async() => {
                WriteLiteral("\n\t\t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 597, "\"", 619, 1);
#nullable restore
#line 22 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Following.cshtml"
WriteAttributeValue("", 603, o["avatar_url"], 603, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" height=\"50\" width=\"50\"><br><br>\n\t\t\t\t\t<button id=\"user\" name=\"user\"");
                BeginWriteAttribute("value", " value=\"", 687, "\"", 706, 1);
#nullable restore
#line 23 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Following.cshtml"
WriteAttributeValue("", 695, o["login"], 695, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 23 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Following.cshtml"
                                                                 Write(o["login"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\n\t\t\t\t");
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
            WriteLiteral("\n\t\t\t\t<hr>\n");
#nullable restore
#line 26 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Following.cshtml"
			}

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Following.cshtml"
             
		} else
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div>");
#nullable restore
#line 29 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Following.cshtml"
            Write(Model.User);

#line default
#line hidden
#nullable disable
            WriteLiteral(" is not following anyone.</div>\n");
#nullable restore
#line 30 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Following.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\n");
#nullable restore
#line 32 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Following.cshtml"
} else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"text-center\">\n\t\t<h1 class=\"display-4\">");
#nullable restore
#line 35 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Following.cshtml"
                         Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\t\t<br><h1>");
#nullable restore
#line 36 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Following.cshtml"
           Write(Model.StatusCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\t\t<p>");
#nullable restore
#line 37 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Following.cshtml"
      Write(Model.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\n\t\t<hr>\n\t</div>\n");
#nullable restore
#line 40 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/Following.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FollowingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Home/GetUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e33b11f88c1a6378f9f7601d6f832fb41961c6b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetUser), @"mvc.1.0.view", @"/Views/Home/GetUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e33b11f88c1a6378f9f7601d6f832fb41961c6b8", @"/Views/Home/GetUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a62d855837ed8317cef1fe8bf8dc4cded93f6b69", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GetUserViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Home/GetUser.cshtml"
  
	ViewData["Title"] = "User Search Result";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Home/GetUser.cshtml"
 if (String.IsNullOrEmpty(Model.Error)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"text-center\">\n\t\t<h1 class=\"display-4\">");
#nullable restore
#line 7 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Home/GetUser.cshtml"
                         Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\t\t<img");
            BeginWriteAttribute("src", " src=\"", 195, "\"", 226, 1);
#nullable restore
#line 8 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Home/GetUser.cshtml"
WriteAttributeValue("", 201, Model.User["avatar_url"], 201, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"200\" width=\"200\"><br>\n\t\t<a");
            BeginWriteAttribute("href", " href=\"", 262, "\"", 292, 1);
#nullable restore
#line 9 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Home/GetUser.cshtml"
WriteAttributeValue("", 269, Model.User["html_url"], 269, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n\t\t\t<h4>");
#nullable restore
#line 10 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Home/GetUser.cshtml"
           Write(Model.User["login"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Home/GetUser.cshtml"
                                 Write(Model.User["name"].ToString() != "" ? $"({Model.User["name"]})" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>\n\t\t</a>\n\t\t<hr>\n\t\t<div class=\"row text-center\">\n\t\t\t<div class=\"col-md-4\">\n\t\t\t\t<h3 class=\"followers\">Followers</h3>\n\t\t\t\t<p>\n\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 527, "\"", 562, 1);
#nullable restore
#line 17 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Home/GetUser.cshtml"
WriteAttributeValue("", 534, Model.User["followers_url"], 534, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Home/GetUser.cshtml"
                                                      Write(Model.User["followers"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n\t\t\t\t</p>\n\t\t\t</div>\n\t\t\t<div class=\"col-md-4\">\n\t\t\t\t<h3>Following</h3>\n\t\t\t\t<p>\n\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 676, "\"", 711, 1);
#nullable restore
#line 23 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Home/GetUser.cshtml"
WriteAttributeValue("", 683, Model.User["following_url"], 683, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Home/GetUser.cshtml"
                                                      Write(Model.User["following"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n\t\t\t\t</p>\n\t\t\t</div>\n\t\t\t<div class=\"col-md-4\">\n\t\t\t\t<h3>Public Repos</h3>\n\t\t\t\t<p>\n\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 828, "\"", 891, 3);
            WriteAttributeValue("", 835, "https://github.com/", 835, 19, true);
#nullable restore
#line 29 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Home/GetUser.cshtml"
WriteAttributeValue("", 854, Model.User["login"], 854, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 874, "?tab=repositories", 874, 17, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Home/GetUser.cshtml"
                                                                                  Write(Model.User["public_repos"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n\t\t\t\t</p>\n\t\t\t</div>\n\n\t\t\t<div class=\"col-md-4\">\n\t\t\t\t<h3>Looking to be hired</h3>\n\t\t\t\t<p style=\"color: orange\">\n\t\t\t\t\t");
#nullable restore
#line 36 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Home/GetUser.cshtml"
                Write(Model.User["hireable"].ToString() != "" ? "Yes" : "No");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t</p>\n\t\t\t</div>\n\t\t\t<div class=\"col-md-4\">\n\t\t\t\t<h3>Bio</h3>\n\t\t\t\t<p style=\"color: orange\">\n\t\t\t\t\t");
#nullable restore
#line 42 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Home/GetUser.cshtml"
                Write(Model.User["bio"].ToString() != "" ? Model.User["bio"] : "User did not set a bio");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t</p>\n\t\t\t</div>\n\t\t\t<div class=\"col-md-4\">\n\t\t\t\t<h3>Company</h3>\n\t\t\t\t<p style=\"color: orange;\">\n\t\t\t\t\t");
#nullable restore
#line 48 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Home/GetUser.cshtml"
                Write(Model.User["company"].ToString() != "" ? Model.User["company"] : "None");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t</p>\n\t\t\t</div>\n\t\t</div>\n\t</div>\n");
#nullable restore
#line 53 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Home/GetUser.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"text-center\">\n\t\t<h1 class=\"display-4\">");
#nullable restore
#line 57 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Home/GetUser.cshtml"
                         Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\t\t<h2>Error</h2><br>\n\t\t<p>");
#nullable restore
#line 59 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Home/GetUser.cshtml"
      Write(Model.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\n\t\t<hr>\n\t</div>\n");
#nullable restore
#line 62 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Home/GetUser.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GetUserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

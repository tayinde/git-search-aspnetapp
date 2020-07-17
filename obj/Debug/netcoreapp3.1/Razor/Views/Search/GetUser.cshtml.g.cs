#pragma checksum "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/GetUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59958ce11795670508d812b2d28dbac8abf02aed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_GetUser), @"mvc.1.0.view", @"/Views/Search/GetUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59958ce11795670508d812b2d28dbac8abf02aed", @"/Views/Search/GetUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a62d855837ed8317cef1fe8bf8dc4cded93f6b69", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_GetUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GetUserViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/GetUser.cshtml"
  
	ViewData["Title"] = "User Search Result";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/GetUser.cshtml"
 if (String.IsNullOrEmpty(Model.Error)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"text-center\">\n\t\t<h1 class=\"display-4\">");
#nullable restore
#line 7 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/GetUser.cshtml"
                         Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\t\t<img");
            BeginWriteAttribute("src", " src=\"", 195, "\"", 226, 1);
#nullable restore
#line 8 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/GetUser.cshtml"
WriteAttributeValue("", 201, Model.User["avatar_url"], 201, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"200\" width=\"200\"><br>\n\t\t<br>\n\t\t<a");
            BeginWriteAttribute("href", " href=\"", 269, "\"", 299, 1);
#nullable restore
#line 10 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/GetUser.cshtml"
WriteAttributeValue("", 276, Model.User["html_url"], 276, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n\t\t\t<h5>");
#nullable restore
#line 11 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/GetUser.cshtml"
           Write(Model.User["login"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/GetUser.cshtml"
                                 Write(Model.User["name"].ToString() != "" ? $"({Model.User["name"]})" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("<h5>\n\t\t</a>\n\t\t<hr>\n\t\t<div class=\"row text-center\">\n\t\t\t<div class=\"col-md-4\">\n\t\t\t\t<h3 class=\"followers\">Followers</h3>\n\t\t\t\t<p>\n\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 534, "\"", 594, 3);
            WriteAttributeValue("", 541, "https://github.com/", 541, 19, true);
#nullable restore
#line 18 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/GetUser.cshtml"
WriteAttributeValue("", 560, Model.User["login"], 560, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 580, "?tab=followers", 580, 14, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/GetUser.cshtml"
                                                                               Write(Model.User["followers"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n\t\t\t\t</p>\n\t\t\t</div>\n\t\t\t<div class=\"col-md-4\">\n\t\t\t\t<h3>Following</h3>\n\t\t\t\t<p>\n\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 708, "\"", 768, 3);
            WriteAttributeValue("", 715, "https://github.com/", 715, 19, true);
#nullable restore
#line 24 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/GetUser.cshtml"
WriteAttributeValue("", 734, Model.User["login"], 734, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 754, "?tab=following", 754, 14, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/GetUser.cshtml"
                                                                               Write(Model.User["following"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n\t\t\t\t</p>\n\t\t\t</div>\n\t\t\t<div class=\"col-md-4\">\n\t\t\t\t<h3>Public Repos</h3>\n\t\t\t\t<p>\n\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 885, "\"", 948, 3);
            WriteAttributeValue("", 892, "https://github.com/", 892, 19, true);
#nullable restore
#line 30 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/GetUser.cshtml"
WriteAttributeValue("", 911, Model.User["login"], 911, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 931, "?tab=repositories", 931, 17, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 30 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/GetUser.cshtml"
                                                                                  Write(Model.User["public_repos"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n\t\t\t\t</p>\n\t\t\t</div>\n\n\t\t\t<div class=\"col-md-4\">\n\t\t\t\t<h3>Looking to be hired</h3>\n\t\t\t\t<p style=\"color: darkgreen\">\n\t\t\t\t\t");
#nullable restore
#line 37 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/GetUser.cshtml"
                Write(Model.User["hireable"].ToString() != "" ? "Yes" : "No");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t</p>\n\t\t\t</div>\n\t\t\t<div class=\"col-md-4\">\n\t\t\t\t<h3>Bio</h3>\n\t\t\t\t<p style=\"color: darkgreen\">\n\t\t\t\t\t");
#nullable restore
#line 43 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/GetUser.cshtml"
                Write(Model.User["bio"].ToString() != "" ? Model.User["bio"] : "User did not set a bio");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t</p>\n\t\t\t</div>\n\t\t\t<div class=\"col-md-4\">\n\t\t\t\t<h3>Company</h3>\n\t\t\t\t<p style=\"color: darkgreen;\">\n\t\t\t\t\t");
#nullable restore
#line 49 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/GetUser.cshtml"
                Write(Model.User["company"].ToString() != "" ? Model.User["company"] : "None");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t</p>\n\t\t\t</div>\n\t\t</div>\n\t</div>\n");
#nullable restore
#line 54 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/GetUser.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"text-center\">\n\t\t<h1 class=\"display-4\">");
#nullable restore
#line 58 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/GetUser.cshtml"
                         Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\t\t<br><h1>");
#nullable restore
#line 59 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/GetUser.cshtml"
           Write(Model.StatusCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\t\t<p>");
#nullable restore
#line 60 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/GetUser.cshtml"
      Write(Model.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\n\t\t<hr>\n\t</div>\n");
#nullable restore
#line 63 "/home/ta334/Codes/C#/git-search-aspnetapp/Views/Search/GetUser.cshtml"
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

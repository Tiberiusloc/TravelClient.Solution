#pragma checksum "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a7813c4648754fbf5e16bbee7efe5646788e803"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\_ViewImports.cshtml"
using TravelClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\_ViewImports.cshtml"
using TravelClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a7813c4648754fbf5e16bbee7efe5646788e803", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"881156204694621735159ac2183c5559087d93d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n<h1>All Reviews:</h1>\r\n\r\n<ol>\r\n");
#nullable restore
#line 13 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Home\Index.cshtml"
 foreach (Review review in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n        <li>ID: ");
#nullable restore
#line 16 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Home\Index.cshtml"
           Write(review.ReviewId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Name: ");
#nullable restore
#line 17 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Home\Index.cshtml"
             Write(review.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>City: ");
#nullable restore
#line 18 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Home\Index.cshtml"
             Write(review.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Country: ");
#nullable restore
#line 19 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Home\Index.cshtml"
                Write(review.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Rating: ");
#nullable restore
#line 20 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Home\Index.cshtml"
               Write(review.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Description: ");
#nullable restore
#line 21 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Home\Index.cshtml"
                    Write(review.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 582, "\"", 624, 2);
            WriteAttributeValue("", 589, "/Reviews/Details/", 589, 17, true);
#nullable restore
#line 23 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Home\Index.cshtml"
WriteAttributeValue("", 606, review.ReviewId, 606, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><p>View Details</p></a>\r\n    <br>\r\n");
#nullable restore
#line 25 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ol>\r\n");
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

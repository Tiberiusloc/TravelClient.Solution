#pragma checksum "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de5492acbe34e9ccf3dcf22efa06e9a19e33edbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reviews_Edit), @"mvc.1.0.view", @"/Views/Reviews/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de5492acbe34e9ccf3dcf22efa06e9a19e33edbb", @"/Views/Reviews/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"881156204694621735159ac2183c5559087d93d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Reviews_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravelClient.Models.Review>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Edit Review:</h1>\r\n<hr>\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
 using (Html.BeginForm("Edit", "Reviews", FormMethod.Post))
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
Write(Html.HiddenFor(model => model.ReviewId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
                                          ;

  

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
                                     ;
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
                                      ;
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
Write(Html.LabelFor(model => model.City));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
                                     ;
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
Write(Html.EditorFor(model => model.City));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
                                      ;
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
Write(Html.LabelFor(model => model.Country));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
                                        ;
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
Write(Html.EditorFor(model => model.Country));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
                                         ;
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
Write(Html.LabelFor(model => model.Rating));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
                                       ;
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
Write(Html.EditorFor(model => model.Rating));

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
                                        ;
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
                                            ;
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
Write(Html.EditorFor(model => model.Description));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
                                             ;

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\">\r\n");
#nullable restore
#line 41 "C:\Users\PCAdmin\Desktop\TravelClient.Solution\TravelClient\Views\Reviews\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TravelClient.Models.Review> Html { get; private set; }
    }
}
#pragma warning restore 1591

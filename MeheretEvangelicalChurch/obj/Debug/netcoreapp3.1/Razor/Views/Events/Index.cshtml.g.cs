#pragma checksum "C:\Users\thm28\Downloads\Compressed\MeheretEvangelicalChurch\MeheretEvangelicalChurch\MeheretEvangelicalChurch\Views\Events\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b15c6411e410029fe07e4b2db28b153e519a500"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Index), @"mvc.1.0.view", @"/Views/Events/Index.cshtml")]
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
#line 1 "C:\Users\thm28\Downloads\Compressed\MeheretEvangelicalChurch\MeheretEvangelicalChurch\MeheretEvangelicalChurch\Views\_ViewImports.cshtml"
using MeheretEvangelicalChurch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thm28\Downloads\Compressed\MeheretEvangelicalChurch\MeheretEvangelicalChurch\MeheretEvangelicalChurch\Views\_ViewImports.cshtml"
using MeheretEvangelicalChurch.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b15c6411e410029fe07e4b2db28b153e519a500", @"/Views/Events/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b26749727795f967bba015ddb3fedbb3a9d27efe", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MeheretEvangelicalChurch.Models.Events>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\thm28\Downloads\Compressed\MeheretEvangelicalChurch\MeheretEvangelicalChurch\MeheretEvangelicalChurch\Views\Events\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""fullwidth-block"">
        <div class=""container"">
            <div class=""row"">
                <div class=""content col-md-8"">
                    <h2 class=""section-title"">Upcoming Events</h2>
                    <ul class=""event-list large"">
");
#nullable restore
#line 14 "C:\Users\thm28\Downloads\Compressed\MeheretEvangelicalChurch\MeheretEvangelicalChurch\MeheretEvangelicalChurch\Views\Events\Index.cshtml"
                         foreach (var item in Model)
                         {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <h3 class=\"event-title\">");
#nullable restore
#line 17 "C:\Users\thm28\Downloads\Compressed\MeheretEvangelicalChurch\MeheretEvangelicalChurch\MeheretEvangelicalChurch\Views\Events\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.EventTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <span class=\"event-meta\">\r\n                                    <span><i class=\"fa fa-calendar\"></i>");
#nullable restore
#line 19 "C:\Users\thm28\Downloads\Compressed\MeheretEvangelicalChurch\MeheretEvangelicalChurch\MeheretEvangelicalChurch\Views\Events\Index.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.EventDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span><i class=\"fa fa-map-marker\"></i>Kitchener</span>\r\n                                </span>\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 997, "\"", 1049, 1);
#nullable restore
#line 22 "C:\Users\thm28\Downloads\Compressed\MeheretEvangelicalChurch\MeheretEvangelicalChurch\MeheretEvangelicalChurch\Views\Events\Index.cshtml"
WriteAttributeValue("", 1003, Html.DisplayFor(modelItem => item.EventImage), 1003, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"450\" height=\"200\" />\r\n                            </li>\r\n");
#nullable restore
#line 24 "C:\Users\thm28\Downloads\Compressed\MeheretEvangelicalChurch\MeheretEvangelicalChurch\MeheretEvangelicalChurch\Views\Events\Index.cshtml"
                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MeheretEvangelicalChurch.Models.Events>> Html { get; private set; }
    }
}
#pragma warning restore 1591
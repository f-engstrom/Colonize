#pragma checksum "c:\Users\Frans\Dropbox\Projects\ASP .Net Core\Colonize\Pages\Fleet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d153fdd3ac98f3e1b2bb44cf810373f4c08f934"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Colonize.Pages.Pages_Fleet), @"mvc.1.0.razor-page", @"/Pages/Fleet.cshtml")]
namespace Colonize.Pages
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
#line 1 "c:\Users\Frans\Dropbox\Projects\ASP .Net Core\Colonize\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Frans\Dropbox\Projects\ASP .Net Core\Colonize\Pages\_ViewImports.cshtml"
using Colonize;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Frans\Dropbox\Projects\ASP .Net Core\Colonize\Pages\_ViewImports.cshtml"
using Colonize.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d153fdd3ac98f3e1b2bb44cf810373f4c08f934", @"/Pages/Fleet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80d72e135310bf3570f90af6fec7429489510a12", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Fleet : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "c:\Users\Frans\Dropbox\Projects\ASP .Net Core\Colonize\Pages\Fleet.cshtml"
  
    ViewData["Title"] = "Fleet";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Ships</h4>\r\n\r\n");
#nullable restore
#line 9 "c:\Users\Frans\Dropbox\Projects\ASP .Net Core\Colonize\Pages\Fleet.cshtml"
 foreach (var ship in Model.Ships) 
{


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card\" style=\"width: 18rem;\">\r\n      <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 206, "\"", 252, 1);
#nullable restore
#line 13 "c:\Users\Frans\Dropbox\Projects\ASP .Net Core\Colonize\Pages\Fleet.cshtml"
WriteAttributeValue("", 212, Html.DisplayFor(Model => ship.ImageUrl), 212, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 253, "\"", 259, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n  <div class=\"card-body\">\r\n    <h5 class=\"card-title\"> ");
#nullable restore
#line 16 "c:\Users\Frans\Dropbox\Projects\ASP .Net Core\Colonize\Pages\Fleet.cshtml"
                       Write(Html.DisplayFor(model => ship.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <p class=\"card-text\"> ");
#nullable restore
#line 17 "c:\Users\Frans\Dropbox\Projects\ASP .Net Core\Colonize\Pages\Fleet.cshtml"
                     Write(Html.DisplayFor(model => ship.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n  </div>\r\n  <ul class=\"list-group list-group-flush\">\r\n\r\n    \r\n     <li class=\"list-group-item\">\r\n         <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 24 "c:\Users\Frans\Dropbox\Projects\ASP .Net Core\Colonize\Pages\Fleet.cshtml"
       Write(Html.DisplayNameFor(model => ship.PassengerCapacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 27 "c:\Users\Frans\Dropbox\Projects\ASP .Net Core\Colonize\Pages\Fleet.cshtml"
       Write(Html.DisplayFor(model => ship.PassengerCapacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd></li>\r\n    \r\n     <li class=\"list-group-item\">\r\n         <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "c:\Users\Frans\Dropbox\Projects\ASP .Net Core\Colonize\Pages\Fleet.cshtml"
       Write(Html.DisplayNameFor(model => ship.Drive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "c:\Users\Frans\Dropbox\Projects\ASP .Net Core\Colonize\Pages\Fleet.cshtml"
       Write(Html.DisplayFor(model => ship.Drive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd></li>\r\n    \r\n  </ul>\r\n  \r\n  </div>\r\n");
#nullable restore
#line 41 "c:\Users\Frans\Dropbox\Projects\ASP .Net Core\Colonize\Pages\Fleet.cshtml"


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FleetModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FleetModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FleetModel>)PageContext?.ViewData;
        public FleetModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "c:\Users\Frans\Dropbox\Projects\ASP .Net Core\Colonize\Areas\Admin\Pages\Ships\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc0565d4065b06abe27542d582d91075a3ab5e69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Pages_Ships_Index), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/Ships/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc0565d4065b06abe27542d582d91075a3ab5e69", @"/Areas/Admin/Pages/Ships/Index.cshtml")]
    public class Areas_Admin_Pages_Ships_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<div class=""row"">
    <div class=""col"">
<h1>Ships</h1>

    </div>

  <a href=""/Admin/Ships/New""><div class=""col btn btn-primary"">Add</div></a>
</div>


<table class=""table table-striped"">
  <thead>
    <tr>
      <th scope=""col"">Name</th>
      <th scope=""col"">Passanger Capacity</th>
      <th scope=""col"">Drive</th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 25 "c:\Users\Frans\Dropbox\Projects\ASP .Net Core\Colonize\Areas\Admin\Pages\Ships\Index.cshtml"
     foreach (var item in Model.Ships) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "c:\Users\Frans\Dropbox\Projects\ASP .Net Core\Colonize\Areas\Admin\Pages\Ships\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "c:\Users\Frans\Dropbox\Projects\ASP .Net Core\Colonize\Areas\Admin\Pages\Ships\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PassengerCapacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "c:\Users\Frans\Dropbox\Projects\ASP .Net Core\Colonize\Areas\Admin\Pages\Ships\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Drive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n       \r\n        </tr>\r\n");
#nullable restore
#line 38 "c:\Users\Frans\Dropbox\Projects\ASP .Net Core\Colonize\Areas\Admin\Pages\Ships\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Colonize.Areas.Admin.Pages.Ships.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Colonize.Areas.Admin.Pages.Ships.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Colonize.Areas.Admin.Pages.Ships.IndexModel>)PageContext?.ViewData;
        public Colonize.Areas.Admin.Pages.Ships.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

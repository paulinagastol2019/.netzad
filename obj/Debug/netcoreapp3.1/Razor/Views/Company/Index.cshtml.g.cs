#pragma checksum "C:\Users\48503\Desktop\.net\.netzad\Views\Company\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5c4d51bd45d0946474dc0652985580efa2862c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Index), @"mvc.1.0.view", @"/Views/Company/Index.cshtml")]
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
#line 1 "C:\Users\48503\Desktop\.net\.netzad\Views\_ViewImports.cshtml"
using WebApplication.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\48503\Desktop\.net\.netzad\Views\_ViewImports.cshtml"
using WebApplication.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5c4d51bd45d0946474dc0652985580efa2862c8", @"/Views/Company/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ba346f5540f5b4328d3af0e3fa362b23edbf88", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<h1>Company Management</h1>\n\n<h2>Add new company</h2>\n\n<p>...</p>\n\n\n");
#nullable restore
#line 11 "C:\Users\48503\Desktop\.net\.netzad\Views\Company\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("       <div class=\"form-group\">\n           ");
#nullable restore
#line 14 "C:\Users\48503\Desktop\.net\.netzad\Views\Company\Index.cshtml"
      Write(Html.LabelFor(x => x.Name, "Company name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n           ");
#nullable restore
#line 15 "C:\Users\48503\Desktop\.net\.netzad\Views\Company\Index.cshtml"
      Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n       </div>\n       <div class=\"form-group\">\n           ");
#nullable restore
#line 18 "C:\Users\48503\Desktop\.net\.netzad\Views\Company\Index.cshtml"
      Write(Html.LabelFor(x => x.Description, "Company description"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n           ");
#nullable restore
#line 19 "C:\Users\48503\Desktop\.net\.netzad\Views\Company\Index.cshtml"
      Write(Html.TextBoxFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n       </div>\n       <div class=\"form-group\">\n           ");
#nullable restore
#line 22 "C:\Users\48503\Desktop\.net\.netzad\Views\Company\Index.cshtml"
      Write(Html.CheckBoxFor(x => x.IsVisible, new { @class = "form-check-input"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n           ");
#nullable restore
#line 23 "C:\Users\48503\Desktop\.net\.netzad\Views\Company\Index.cshtml"
      Write(Html.LabelFor(x => x.IsVisible, "Visible", new { @gclass = "form-check-label"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n       </div>\n       <div class=\"form-group\">\n           <button type=\"submit\" class=\"btn btn-primary\">Add Company</button>\n       </div>\n");
#nullable restore
#line 28 "C:\Users\48503\Desktop\.net\.netzad\Views\Company\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompanyModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\abhim\OneDrive\Documents\GitHub\IS7012\CoreCrud\Pages\CountryProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05a5de9de6fa0801a69213f3cdb0c14609454a76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CoreCrud.Pages.Pages_CountryProfile), @"mvc.1.0.razor-page", @"/Pages/CountryProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/CountryProfile.cshtml", typeof(CoreCrud.Pages.Pages_CountryProfile), null)]
namespace CoreCrud.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\abhim\OneDrive\Documents\GitHub\IS7012\CoreCrud\Pages\_ViewImports.cshtml"
using CoreCrud;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05a5de9de6fa0801a69213f3cdb0c14609454a76", @"/Pages/CountryProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70be34fe23130313fbdf16acefe8f2e4f5da9be3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CountryProfile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 77, true);
            WriteLiteral("\r\n\r\n<h1>Country Profile</h1>\r\n<h4 class=\"text-center text-success\">Country : ");
            EndContext();
            BeginContext(120, 18, false);
#line 8 "C:\Users\abhim\OneDrive\Documents\GitHub\IS7012\CoreCrud\Pages\CountryProfile.cshtml"
                                          Write(Model.Country.Name);

#line default
#line hidden
            EndContext();
            BeginContext(138, 276, true);
            WriteLiteral(@"</h2>

<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th>Team Id</th>
            <th>Team Name</th>
            <th>Junior/Senior</th>
            <th>Inter College Eligibility</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 20 "C:\Users\abhim\OneDrive\Documents\GitHub\IS7012\CoreCrud\Pages\CountryProfile.cshtml"
         foreach(var team in Model.Country.Teams) {

#line default
#line hidden
            BeginContext(467, 39, true);
            WriteLiteral("             <tr>\r\n                <td>");
            EndContext();
            BeginContext(507, 7, false);
#line 22 "C:\Users\abhim\OneDrive\Documents\GitHub\IS7012\CoreCrud\Pages\CountryProfile.cshtml"
               Write(team.Id);

#line default
#line hidden
            EndContext();
            BeginContext(514, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(542, 9, false);
#line 23 "C:\Users\abhim\OneDrive\Documents\GitHub\IS7012\CoreCrud\Pages\CountryProfile.cshtml"
               Write(team.Name);

#line default
#line hidden
            EndContext();
            BeginContext(551, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(579, 19, false);
#line 24 "C:\Users\abhim\OneDrive\Documents\GitHub\IS7012\CoreCrud\Pages\CountryProfile.cshtml"
               Write(team.JuniorOrSenior);

#line default
#line hidden
            EndContext();
            BeginContext(598, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 25 "C:\Users\abhim\OneDrive\Documents\GitHub\IS7012\CoreCrud\Pages\CountryProfile.cshtml"
                 if(@team.JuniorOrSenior=="Senior") {

#line default
#line hidden
            BeginContext(660, 34, true);
            WriteLiteral("                    <td>Yes</td>\r\n");
            EndContext();
#line 27 "C:\Users\abhim\OneDrive\Documents\GitHub\IS7012\CoreCrud\Pages\CountryProfile.cshtml"
                } else {

#line default
#line hidden
            BeginContext(720, 33, true);
            WriteLiteral("                    <td>No</td>\r\n");
            EndContext();
#line 29 "C:\Users\abhim\OneDrive\Documents\GitHub\IS7012\CoreCrud\Pages\CountryProfile.cshtml"
                }

#line default
#line hidden
            BeginContext(772, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 31 "C:\Users\abhim\OneDrive\Documents\GitHub\IS7012\CoreCrud\Pages\CountryProfile.cshtml"
        }

#line default
#line hidden
            BeginContext(802, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CountryProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CountryProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CountryProfileModel>)PageContext?.ViewData;
        public CountryProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

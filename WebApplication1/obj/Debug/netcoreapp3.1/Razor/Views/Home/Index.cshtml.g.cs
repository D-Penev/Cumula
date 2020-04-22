#pragma checksum "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c2bcf1e9d32eaeaa4019352ce6b7b3ff2e5e0b4"
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
#line 1 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Home\Index.cshtml"
using BMS.Models.ViewModels.Flights;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c2bcf1e9d32eaeaa4019352ce6b7b3ff2e5e0b4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DisplayDailyFlightViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Home\Index.cshtml"
  
    this.ViewData["Title"] = "Landing...";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Home\Index.cshtml"
 if (this.signInManager.IsSignedIn(User))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Home\Index.cshtml"
     if (Model.Flights.Count == 0)
    {
        
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""col"">
        <h1 class=""text-center"">Daily flights</h1>
        <br />
        <table class=""table table-bordered table-hover text-center"" id=""dailyMovements"">
            <thead class=""thead-dark table-striped"">
                <tr>
                    <th scope=""col"">Flight Number</th>
                    <th scope=""col"">A/C Registration</th>
                    <th scope=""col"">A/C Type</th>     
                    <th scope=""col"">Destination</th>
                    <th scope=""col"">STD</th>
                    <th scope=""col"">R/A</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 30 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Home\Index.cshtml"
                 foreach (var flight in Model.Flights)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <tr>\r\n                       <td>");
#nullable restore
#line 33 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Home\Index.cshtml"
                      Write(flight.FlightNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                       <td>");
#nullable restore
#line 34 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Home\Index.cshtml"
                      Write(flight.Registration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                       <td>");
#nullable restore
#line 35 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Home\Index.cshtml"
                      Write(flight.AircraftType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                       <td>");
#nullable restore
#line 36 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Home\Index.cshtml"
                      Write(flight.Destination);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                       <td>");
#nullable restore
#line 37 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Home\Index.cshtml"
                      Write(flight.STD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                       <td>");
#nullable restore
#line 38 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Home\Index.cshtml"
                      Write(flight.RampAgent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 44 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DisplayDailyFlightViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

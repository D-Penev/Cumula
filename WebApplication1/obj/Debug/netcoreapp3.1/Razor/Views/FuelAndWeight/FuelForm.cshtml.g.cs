#pragma checksum "C:\Users\Mitko\Documents\GitHub\Bastun-Management-System\WebApplication1\Views\FuelAndWeight\FuelForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c199b5a4764f7713e98948a61f93d9c674595a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FuelAndWeight_FuelForm), @"mvc.1.0.view", @"/Views/FuelAndWeight/FuelForm.cshtml")]
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
#line 1 "C:\Users\Mitko\Documents\GitHub\Bastun-Management-System\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mitko\Documents\GitHub\Bastun-Management-System\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mitko\Documents\GitHub\Bastun-Management-System\WebApplication1\Views\FuelAndWeight\FuelForm.cshtml"
using BMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c199b5a4764f7713e98948a61f93d9c674595a9", @"/Views/FuelAndWeight/FuelForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_FuelAndWeight_FuelForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FuelFormInputModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FuelAndWeight", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RegisterFuelForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Mitko\Documents\GitHub\Bastun-Management-System\WebApplication1\Views\FuelAndWeight\FuelForm.cshtml"
   
    this.ViewData["Title"] = "Add fuel form";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"col\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c199b5a4764f7713e98948a61f93d9c674595a94479", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label for=""flightNumber"">Flight Number:</label>
            <input type=""text""class=""form-control w-100"" />
        </div>
        <div class=""form-group"">
            <label for=""a/cRegistration"">Registration:</label>
            <input type=""text""  class=""form-control w-100""/>
        </div>
        <div class=""form-group"">
            <label for=""date"">Date:</label>
            <input type=""datetime"" class=""form-control w-100"" />
        </div>
        <div class=""form-group"">
            <label for=""picName"">PIC:</label>
            <input type=""text"" class=""form-control w-100""/>
        </div>
        <div class=""form-group"">
            <label for=""crewConfiguration"">
                 Crew Configuration:
            </label>
            <input type=""text"" class=""form-control w-100""/>
        </div>
        <div class=""form-group"">
            <label for=""taxiFuel"">Taxi:</label>
            <input type=""number"" class=""form-control w-");
                WriteLiteral(@"100"" />
        </div>
        <div class=""form-group"">
            <label for=""blockFuel"">Block:</label>
            <input type=""number"" class=""form-control w-100"" />
        </div>
        <div class=""form-group"">
            <label for=""tripFuel"">Trip:</label>
            <input type=""number"" class=""form-control w-100"" />
        </div>
        <div class=""form-group"">
            <label>Takeoff fuel:</label>
            <input type=""number"" class=""form-control w-100"" />
        </div>
        <div class=""form-group"">
            <label for=""dryOperatingWeight"">DOW:</label>
            <input type=""text"" class=""form-control w-100"" />
        </div>
        <div class=""form-group"">
            <label for=""dryOperatingIndex"">DOI:</label>
            <input type=""text"" class=""form-control w-100"" />
        </div>
        <button type=""submit"" class=""btn btn-primary btn-lg w-100"">Submit</button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FuelFormInputModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

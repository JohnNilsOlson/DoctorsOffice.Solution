#pragma checksum "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/AddSpecialty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "947a6777a8811d57b3f6ce9fc1b8152cc65bd23f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctors_AddSpecialty), @"mvc.1.0.view", @"/Views/Doctors/AddSpecialty.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Doctors/AddSpecialty.cshtml", typeof(AspNetCore.Views_Doctors_AddSpecialty))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"947a6777a8811d57b3f6ce9fc1b8152cc65bd23f", @"/Views/Doctors/AddSpecialty.cshtml")]
    public class Views_Doctors_AddSpecialty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoctorsOffice.Models.Doctor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/AddSpecialty.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(63, 46, true);
            WriteLiteral("\n<h1>Add Specialty for Doctor</h1>\n<hr />\n<h3>");
            EndContext();
            BeginContext(110, 14, false);
#line 9 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/AddSpecialty.cshtml"
Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(124, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(127, 15, false);
#line 9 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/AddSpecialty.cshtml"
                Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(142, 7, true);
            WriteLiteral("</h3>\n\n");
            EndContext();
#line 11 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/AddSpecialty.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(182, 39, false);
#line 13 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/AddSpecialty.cshtml"
Write(Html.HiddenFor(model => model.DoctorId));

#line default
#line hidden
            EndContext();
            BeginContext(228, 30, false);
#line 15 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/AddSpecialty.cshtml"
Write(Html.Label("Select Specialty"));

#line default
#line hidden
            EndContext();
            BeginContext(264, 32, false);
#line 16 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/AddSpecialty.cshtml"
Write(Html.DropDownList("SpecialtyId"));

#line default
#line hidden
            EndContext();
            BeginContext(298, 65, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\n");
            EndContext();
#line 19 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/AddSpecialty.cshtml"
}

#line default
#line hidden
            BeginContext(365, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(370, 50, false);
#line 21 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/AddSpecialty.cshtml"
Write(Html.ActionLink("Back to Specialty List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(420, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoctorsOffice.Models.Doctor> Html { get; private set; }
    }
}
#pragma warning restore 1591

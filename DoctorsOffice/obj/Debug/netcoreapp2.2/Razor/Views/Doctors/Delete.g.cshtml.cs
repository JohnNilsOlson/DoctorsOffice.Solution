#pragma checksum "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3b0150c25a361b3f503063e68d04d17c5bcfc04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctors_Delete), @"mvc.1.0.view", @"/Views/Doctors/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Doctors/Delete.cshtml", typeof(AspNetCore.Views_Doctors_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b0150c25a361b3f503063e68d04d17c5bcfc04", @"/Views/Doctors/Delete.cshtml")]
    public class Views_Doctors_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoctorsOffice.Models.Doctor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(63, 59, true);
            WriteLiteral("\n<h2>Are you sure you want to delete this doctor?</h2>\n\n<p>");
            EndContext();
            BeginContext(123, 15, false);
#line 9 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Delete.cshtml"
Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(138, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(140, 14, false);
#line 9 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Delete.cshtml"
               Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(154, 6, true);
            WriteLiteral("</p>\n\n");
            EndContext();
#line 11 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(188, 43, true);
            WriteLiteral("    <input type=\"submit\" value=\"Delete\" />\n");
            EndContext();
#line 14 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Delete.cshtml"
}

#line default
#line hidden
            BeginContext(234, 46, false);
#line 15 "/Users/thomasglenn/Desktop/Csharp/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Delete.cshtml"
Write(Html.ActionLink("Back to categories", "Index"));

#line default
#line hidden
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
#pragma checksum "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-lecture-autumn-ragland\Lecture\Views\HouseParty\NewInvite.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74c8f73e1e305b875b7ee0b51b7afde5c0291a43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HouseParty_NewInvite), @"mvc.1.0.view", @"/Views/HouseParty/NewInvite.cshtml")]
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
#line 1 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-lecture-autumn-ragland\Lecture\Views\_ViewImports.cshtml"
using Lecture;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-lecture-autumn-ragland\Lecture\Views\_ViewImports.cshtml"
using Lecture.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74c8f73e1e305b875b7ee0b51b7afde5c0291a43", @"/Views/HouseParty/NewInvite.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0db0d87f27675381b31528781b611e9b99c0698a", @"/Views/_ViewImports.cshtml")]
    public class Views_HouseParty_NewInvite : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lecture.Models.Invite>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Add New Invite</h1>\r\n");
#nullable restore
#line 3 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-lecture-autumn-ragland\Lecture\Views\HouseParty\NewInvite.cshtml"
 using (@Html.BeginForm("AddInvite", "HouseParty"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 6 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-lecture-autumn-ragland\Lecture\Views\HouseParty\NewInvite.cshtml"
   Write(Html.LabelFor(m => m.inviteName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 7 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-lecture-autumn-ragland\Lecture\Views\HouseParty\NewInvite.cshtml"
   Write(Html.TextBoxFor(m => m.inviteName, new { @class="form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-check form-check-inline\">\r\n        ");
#nullable restore
#line 10 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-lecture-autumn-ragland\Lecture\Views\HouseParty\NewInvite.cshtml"
   Write(Html.CheckBoxFor(m => m.isAttending, new { @class="form-check-input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 11 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-lecture-autumn-ragland\Lecture\Views\HouseParty\NewInvite.cshtml"
   Write(Html.LabelFor(m => m.isAttending, new { @class="form-check-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 14 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-lecture-autumn-ragland\Lecture\Views\HouseParty\NewInvite.cshtml"
   Write(Html.LabelFor(m => m.numberAttended));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 15 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-lecture-autumn-ragland\Lecture\Views\HouseParty\NewInvite.cshtml"
   Write(Html.TextBoxFor(m => m.numberAttended, new { @class="form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 18 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-lecture-autumn-ragland\Lecture\Views\HouseParty\NewInvite.cshtml"
   Write(Html.LabelFor(m => m.age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 19 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-lecture-autumn-ragland\Lecture\Views\HouseParty\NewInvite.cshtml"
   Write(Html.TextBoxFor(m => m.age, new { @class="form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n");
#nullable restore
#line 22 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-lecture-autumn-ragland\Lecture\Views\HouseParty\NewInvite.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lecture.Models.Invite> Html { get; private set; }
    }
}
#pragma warning restore 1591

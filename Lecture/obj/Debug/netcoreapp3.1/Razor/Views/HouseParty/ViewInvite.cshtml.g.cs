#pragma checksum "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-lecture-autumn-ragland\Lecture\Views\HouseParty\ViewInvite.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df99e06396ee0e64ffc567afa2dcacefb80f6afe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HouseParty_ViewInvite), @"mvc.1.0.view", @"/Views/HouseParty/ViewInvite.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df99e06396ee0e64ffc567afa2dcacefb80f6afe", @"/Views/HouseParty/ViewInvite.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0db0d87f27675381b31528781b611e9b99c0698a", @"/Views/_ViewImports.cshtml")]
    public class Views_HouseParty_ViewInvite : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lecture.Models.Invite>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>View Invite</h1>\r\n<div class=\"card\" style=\"width: 18rem;\">\r\n  <div class=\"card-body\">\r\n    <h5 class=\"card-title\">ID : ");
#nullable restore
#line 5 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-lecture-autumn-ragland\Lecture\Views\HouseParty\ViewInvite.cshtml"
                           Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <h5 class=\"card-title\">Name : ");
#nullable restore
#line 6 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-lecture-autumn-ragland\Lecture\Views\HouseParty\ViewInvite.cshtml"
                             Write(Model.inviteName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <h6 class=\"card-subtitle mb-2 text-muted\">Is Attending : ");
#nullable restore
#line 7 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-lecture-autumn-ragland\Lecture\Views\HouseParty\ViewInvite.cshtml"
                                                        Write(Model.isAttending);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    <p class=\"card-text\">Parties Attended : ");
#nullable restore
#line 8 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-lecture-autumn-ragland\Lecture\Views\HouseParty\ViewInvite.cshtml"
                                       Write(Model.numberAttended);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p class=\"card-text\">Age : ");
#nullable restore
#line 9 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-lecture-autumn-ragland\Lecture\Views\HouseParty\ViewInvite.cshtml"
                          Write(Model.age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n  </div>\r\n</div>");
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

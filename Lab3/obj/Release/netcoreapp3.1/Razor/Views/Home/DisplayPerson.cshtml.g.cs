#pragma checksum "C:\Users\Andre\source\repos\Lab3\Lab3\Views\Home\DisplayPerson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19a5b197d7c0dc78b9d4cbee54f93b94f343c1b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DisplayPerson), @"mvc.1.0.view", @"/Views/Home/DisplayPerson.cshtml")]
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
#line 1 "C:\Users\Andre\source\repos\Lab3\Lab3\Views\_ViewImports.cshtml"
using Lab3;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19a5b197d7c0dc78b9d4cbee54f93b94f343c1b7", @"/Views/Home/DisplayPerson.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a751612b2fc984c26e731dce5dcbeb6ea8d86a72", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DisplayPerson : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Person information</h1>\r\n<p>\r\n    First Name: ");
#nullable restore
#line 3 "C:\Users\Andre\source\repos\Lab3\Lab3\Views\Home\DisplayPerson.cshtml"
           Write(ViewBag.fName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    Last Name: ");
#nullable restore
#line 4 "C:\Users\Andre\source\repos\Lab3\Lab3\Views\Home\DisplayPerson.cshtml"
          Write(ViewBag.lName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    Age: ");
#nullable restore
#line 5 "C:\Users\Andre\source\repos\Lab3\Lab3\Views\Home\DisplayPerson.cshtml"
    Write(ViewBag.age);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    Email Address: ");
#nullable restore
#line 6 "C:\Users\Andre\source\repos\Lab3\Lab3\Views\Home\DisplayPerson.cshtml"
              Write(ViewBag.email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    Password: ");
#nullable restore
#line 7 "C:\Users\Andre\source\repos\Lab3\Lab3\Views\Home\DisplayPerson.cshtml"
         Write(ViewBag.password);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    Description: ");
#nullable restore
#line 8 "C:\Users\Andre\source\repos\Lab3\Lab3\Views\Home\DisplayPerson.cshtml"
            Write(ViewBag.description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

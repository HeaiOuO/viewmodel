#pragma checksum "C:\Users\heai0\OneDrive\Desktop\ViewModel\Views\Home\users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f00ace240a08b6d10985f0ea773c647db05c3b58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_users), @"mvc.1.0.view", @"/Views/Home/users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/users.cshtml", typeof(AspNetCore.Views_Home_users))]
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
#line 1 "C:\Users\heai0\OneDrive\Desktop\ViewModel\Views\_ViewImports.cshtml"
using ViewModel;

#line default
#line hidden
#line 1 "C:\Users\heai0\OneDrive\Desktop\ViewModel\Views\Home\users.cshtml"
using ViewModel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f00ace240a08b6d10985f0ea773c647db05c3b58", @"/Views/Home/users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"147e23ca4f5315fe200c88601892203f60461b1e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 36, true);
            WriteLiteral("    <h3>these are some Users!</h3>\r\n");
            EndContext();
#line 4 "C:\Users\heai0\OneDrive\Desktop\ViewModel\Views\Home\users.cshtml"
  
    foreach(var x in @Model.users){

#line default
#line hidden
            BeginContext(115, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(127, 1, false);
#line 6 "C:\Users\heai0\OneDrive\Desktop\ViewModel\Views\Home\users.cshtml"
      Write(x);

#line default
#line hidden
            EndContext();
            BeginContext(128, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 7 "C:\Users\heai0\OneDrive\Desktop\ViewModel\Views\Home\users.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591

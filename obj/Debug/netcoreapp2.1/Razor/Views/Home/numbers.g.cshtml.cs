#pragma checksum "C:\Users\heai0\OneDrive\Desktop\ViewModel\Views\Home\numbers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3fb1829fae5805020989fe805222b0f047c9627"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_numbers), @"mvc.1.0.view", @"/Views/Home/numbers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/numbers.cshtml", typeof(AspNetCore.Views_Home_numbers))]
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
#line 2 "C:\Users\heai0\OneDrive\Desktop\ViewModel\Views\Home\numbers.cshtml"
using ViewModel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3fb1829fae5805020989fe805222b0f047c9627", @"/Views/Home/numbers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"147e23ca4f5315fe200c88601892203f60461b1e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_numbers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Number>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 33, true);
            WriteLiteral("<h3>Here are some numbers!</h3>\r\n");
            EndContext();
#line 4 "C:\Users\heai0\OneDrive\Desktop\ViewModel\Views\Home\numbers.cshtml"
  
    foreach(var x in @Model.list){

#line default
#line hidden
            BeginContext(113, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(125, 1, false);
#line 6 "C:\Users\heai0\OneDrive\Desktop\ViewModel\Views\Home\numbers.cshtml"
      Write(x);

#line default
#line hidden
            EndContext();
            BeginContext(126, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 7 "C:\Users\heai0\OneDrive\Desktop\ViewModel\Views\Home\numbers.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Number> Html { get; private set; }
    }
}
#pragma warning restore 1591
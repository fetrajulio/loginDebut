#pragma checksum "C:\Users\IdealyRakotoarimanan\source\repos\entityCodeFirst\entityCodeFirst\Views\User\IndexUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "675eb599b4f6c19cba15e06705682f652d655296"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_IndexUser), @"mvc.1.0.view", @"/Views/User/IndexUser.cshtml")]
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
#line 1 "C:\Users\IdealyRakotoarimanan\source\repos\entityCodeFirst\entityCodeFirst\Views\_ViewImports.cshtml"
using entityCodeFirst;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\IdealyRakotoarimanan\source\repos\entityCodeFirst\entityCodeFirst\Views\_ViewImports.cshtml"
using entityCodeFirst.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"675eb599b4f6c19cba15e06705682f652d655296", @"/Views/User/IndexUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"630e601127a6312d85e8686400449e7a6b33d804", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_IndexUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>");
#nullable restore
#line 6 "C:\Users\IdealyRakotoarimanan\source\repos\entityCodeFirst\entityCodeFirst\Views\User\IndexUser.cshtml"
Write(ViewBag.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n <input type=\"button\" class=\"btn btn-secondary\" onclick=\"location.href=\'https://localhost:44370/user/deconect\';\" value=\"Deconecter\" />");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

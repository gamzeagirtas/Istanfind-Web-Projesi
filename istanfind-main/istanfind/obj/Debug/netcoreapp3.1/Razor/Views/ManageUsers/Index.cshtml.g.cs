#pragma checksum "C:\Users\gamze\Desktop\istanfind-main\istanfind\Views\ManageUsers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81de1bbfa1198c67e4e1fb9b3d0fb1266ee20960"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManageUsers_Index), @"mvc.1.0.view", @"/Views/ManageUsers/Index.cshtml")]
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
#line 1 "C:\Users\gamze\Desktop\istanfind-main\istanfind\Views\_ViewImports.cshtml"
using istanfind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gamze\Desktop\istanfind-main\istanfind\Views\_ViewImports.cshtml"
using istanfind.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gamze\Desktop\istanfind-main\istanfind\Views\ManageUsers\Index.cshtml"
using istanfind.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81de1bbfa1198c67e4e1fb9b3d0fb1266ee20960", @"/Views/ManageUsers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23f47237e6e6e2a4b38c83cc454fdae42e2f589d", @"/Views/_ViewImports.cshtml")]
    public class Views_ManageUsers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<istanfind.Controllers.ManageUsersViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\gamze\Desktop\istanfind-main\istanfind\Views\ManageUsers\Index.cshtml"
   ViewData["Title"] = "Manage users"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>");
#nullable restore
#line 6 "C:\Users\gamze\Desktop\istanfind-main\istanfind\Views\ManageUsers\Index.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("kullaniciyonet"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<hr />\n\n<h3>");
#nullable restore
#line 9 "C:\Users\gamze\Desktop\istanfind-main\istanfind\Views\ManageUsers\Index.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("adminler"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n<table class=\"table\">\n\t<thead>\n\t\t<tr>\n\t\t\t<td>Id</td>\n\t\t\t<td>Email</td>\n\t\t</tr>\n\t</thead>\n\n");
#nullable restore
#line 19 "C:\Users\gamze\Desktop\istanfind-main\istanfind\Views\ManageUsers\Index.cshtml"
     foreach (var user in Model.Administrators)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<tr>\n\t\t\t<td>");
#nullable restore
#line 22 "C:\Users\gamze\Desktop\istanfind-main\istanfind\Views\ManageUsers\Index.cshtml"
           Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\t\t\t<td>");
#nullable restore
#line 23 "C:\Users\gamze\Desktop\istanfind-main\istanfind\Views\ManageUsers\Index.cshtml"
           Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\t\t</tr>\n");
#nullable restore
#line 25 "C:\Users\gamze\Desktop\istanfind-main\istanfind\Views\ManageUsers\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n<h3>");
#nullable restore
#line 28 "C:\Users\gamze\Desktop\istanfind-main\istanfind\Views\ManageUsers\Index.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("herkes"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n<table class=\"table\">\n\t<thead>\n\t\t<tr>\n\t\t\t<td>Id</td>\n\t\t\t<td>Email</td>\n\t\t</tr>\n\t</thead>\n\n");
#nullable restore
#line 38 "C:\Users\gamze\Desktop\istanfind-main\istanfind\Views\ManageUsers\Index.cshtml"
     foreach (var user in Model.Everyone)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<tr>\n\t\t\t<td>");
#nullable restore
#line 41 "C:\Users\gamze\Desktop\istanfind-main\istanfind\Views\ManageUsers\Index.cshtml"
           Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\t\t\t<td>");
#nullable restore
#line 42 "C:\Users\gamze\Desktop\istanfind-main\istanfind\Views\ManageUsers\Index.cshtml"
           Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\t\t</tr>\n");
#nullable restore
#line 44 "C:\Users\gamze\Desktop\istanfind-main\istanfind\Views\ManageUsers\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LocService SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<istanfind.Controllers.ManageUsersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

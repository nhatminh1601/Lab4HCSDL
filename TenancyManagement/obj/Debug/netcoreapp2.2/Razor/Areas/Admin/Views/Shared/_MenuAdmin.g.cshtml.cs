#pragma checksum "D:\LabHCSDL\Lab4HCSDL\TenancyManagement\Areas\Admin\Views\Shared\_MenuAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43e493ebd28dcddf76253f8b049fdc82c3795bb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__MenuAdmin), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_MenuAdmin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/_MenuAdmin.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared__MenuAdmin))]
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
#line 1 "D:\LabHCSDL\Lab4HCSDL\TenancyManagement\Areas\Admin\Views\_ViewImports.cshtml"
using TenancyManagement;

#line default
#line hidden
#line 2 "D:\LabHCSDL\Lab4HCSDL\TenancyManagement\Areas\Admin\Views\_ViewImports.cshtml"
using TenancyManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43e493ebd28dcddf76253f8b049fdc82c3795bb8", @"/Areas/Admin/Views/Shared/_MenuAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e614094adaa7522ac4774dbd7d233ed38254854b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__MenuAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2527, true);
            WriteLiteral(@"<div class=""page-sidebar navbar-collapse collapse"">
    <!-- BEGIN SIDEBAR MENU -->
    <!-- DOC: Apply ""page-sidebar-menu-light"" class right after ""page-sidebar-menu"" to enable light sidebar menu style(without borders) -->
    <!-- DOC: Apply ""page-sidebar-menu-hover-submenu"" class right after ""page-sidebar-menu"" to enable hoverable(hover vs accordion) sub menu mode -->
    <!-- DOC: Apply ""page-sidebar-menu-closed"" class right after ""page-sidebar-menu"" to collapse(""page-sidebar-closed"" class must be applied to the body element) the sidebar sub menu mode -->
    <!-- DOC: Set data-auto-scroll=""false"" to disable the sidebar from auto scrolling/focusing -->
    <!-- DOC: Set data-keep-expand=""true"" to keep the submenues expanded -->
    <!-- DOC: Set data-auto-speed=""200"" to adjust the sub menu slide up/down speed -->
    <ul class=""page-sidebar-menu  page-header-fixed "" data-keep-expanded=""false"" data-auto-scroll=""true"" data-slide-speed=""200"" style=""padding-top: 20px"">
        <!-- DOC: To remove the");
            WriteLiteral(@" sidebar toggler from the sidebar you just need to completely remove the below ""sidebar-toggler-wrapper"" LI element -->
        <li class=""sidebar-toggler-wrapper hide"">
            <!-- BEGIN SIDEBAR TOGGLER BUTTON -->
            <div class=""sidebar-toggler"">
                <span></span>
            </div>
            <!-- END SIDEBAR TOGGLER BUTTON -->
        </li>
        <!-- DOC: To remove the search box from the sidebar you just need to completely remove the below ""sidebar-search-wrapper"" LI element -->
  
        <li class=""heading"">
            <h3 class=""uppercase"">Features</h3>
        </li>

        <li class=""nav-item  "">
            <a href=""/admin/config"" class=""nav-link"">
                <i class=""fa fa-cog""></i>
                <span class=""title"">Cấu Hình</span>
                <span class=""arrow""></span>
            </a>
        </li>
        <li class=""nav-item  "">
            <a href=""/admin/contact"" class=""nav-link"">
                <i class=""fa fa-comment-o""></i");
            WriteLiteral(@">
                <span class=""title"">Liên Hệ</span>
                <span class=""arrow""></span>
            </a>
        </li>
        <li class=""nav-item  "">
            <a href=""/admin/new"" class=""nav-link"">
                <i class=""icon-graph""></i>
                <span class=""title"">Tin Tức</span>
                <span class=""arrow""></span>
            </a>
        </li>

    </ul>
    <!-- END SIDEBAR MENU -->
    <!-- END SIDEBAR MENU -->
</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

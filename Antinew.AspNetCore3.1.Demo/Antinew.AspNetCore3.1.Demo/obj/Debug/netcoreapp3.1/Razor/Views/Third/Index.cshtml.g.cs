#pragma checksum "C:\Antinew\Architect\ASP.NET Core3.1\Antinew.AspNetCore3.1.Demo\Antinew.AspNetCore3.1.Demo\Views\Third\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ea6ac8a2c2b543f0e38cd4a9875ca05e5798182"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Third_Index), @"mvc.1.0.view", @"/Views/Third/Index.cshtml")]
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
#line 1 "C:\Antinew\Architect\ASP.NET Core3.1\Antinew.AspNetCore3.1.Demo\Antinew.AspNetCore3.1.Demo\Views\_ViewImports.cshtml"
using Antinew.AspNetCore3._1.Demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Antinew\Architect\ASP.NET Core3.1\Antinew.AspNetCore3.1.Demo\Antinew.AspNetCore3.1.Demo\Views\_ViewImports.cshtml"
using Antinew.AspNetCore3._1.Demo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ea6ac8a2c2b543f0e38cd4a9875ca05e5798182", @"/Views/Third/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bee11f5dd40aec950af7967a209eedd86efd1d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Third_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Antinew\Architect\ASP.NET Core3.1\Antinew.AspNetCore3.1.Demo\Antinew.AspNetCore3.1.Demo\Views\Third\Index.cshtml"
  
    Console.WriteLine("视图执行。。");
    ViewData["Title"] = "IndexPage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 8 "C:\Antinew\Architect\ASP.NET Core3.1\Antinew.AspNetCore3.1.Demo\Antinew.AspNetCore3.1.Demo\Views\Third\Index.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Action Time：");
#nullable restore
#line 9 "C:\Antinew\Architect\ASP.NET Core3.1\Antinew.AspNetCore3.1.Demo\Antinew.AspNetCore3.1.Demo\Views\Third\Index.cshtml"
           Write(base.ViewBag.Now.ToString("yyyy-MM-dd HH:mm:ss fff"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>View Time：");
#nullable restore
#line 10 "C:\Antinew\Architect\ASP.NET Core3.1\Antinew.AspNetCore3.1.Demo\Antinew.AspNetCore3.1.Demo\Views\Third\Index.cshtml"
         Write(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Aluno\Source\Repos\DragonWinterIsComing\DragonWinterIsComing\Views\Pessoas\PaginaPiloto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00f8a1093035a5475f291e4a0b2d56a078c7daaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoas_PaginaPiloto), @"mvc.1.0.view", @"/Views/Pessoas/PaginaPiloto.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pessoas/PaginaPiloto.cshtml", typeof(AspNetCore.Views_Pessoas_PaginaPiloto))]
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
#line 1 "C:\Users\Aluno\Source\Repos\DragonWinterIsComing\DragonWinterIsComing\Views\_ViewImports.cshtml"
using DragonWinterIsComing;

#line default
#line hidden
#line 2 "C:\Users\Aluno\Source\Repos\DragonWinterIsComing\DragonWinterIsComing\Views\_ViewImports.cshtml"
using DragonWinterIsComing.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00f8a1093035a5475f291e4a0b2d56a078c7daaf", @"/Views/Pessoas/PaginaPiloto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79e18775e641a46cc05a4811d521ff675984fbd1", @"/Views/_ViewImports.cshtml")]
    public class Views_Pessoas_PaginaPiloto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Viagem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 1296, true);
            WriteLiteral(@"
<nav class=""navbar navbar-expand-lg navbar-dark bg-dark"">
    <a class=""navbar-brand"" href=""#"">Navbar</a>
    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarColor02"" aria-controls=""navbarColor02"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""navbar-toggler-icon""></span>
    </button>

    <div class=""collapse navbar-collapse"" id=""navbarColor02"">
        <ul class=""navbar-nav mr-auto"">
            <li class=""nav-item active"">
                <a class=""nav-link"" href=""#"">Home <span class=""sr-only"">(current)</span></a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""#"">Meus Dados</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""#"">Minha nave</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""#"">Dashboard Pilotos</a>
            </li>
        </ul>
    </div>
</nav>
<table class=""");
            WriteLiteral(@"table-light"">
    <thead>
        <tr>
            <th>Data</th>
            <th>Cliente</th>
            <th>Planeta origem</th>
            <th>Planeta destino</th>
            <th>Status</th>
            <th>Nota</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 38 "C:\Users\Aluno\Source\Repos\DragonWinterIsComing\DragonWinterIsComing\Views\Pessoas\PaginaPiloto.cshtml"
         foreach(Viagem item in Model)
        {

#line default
#line hidden
            BeginContext(1368, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1399, 9, false);
#line 41 "C:\Users\Aluno\Source\Repos\DragonWinterIsComing\DragonWinterIsComing\Views\Pessoas\PaginaPiloto.cshtml"
           Write(item.Data);

#line default
#line hidden
            EndContext();
            BeginContext(1408, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1432, 12, false);
#line 42 "C:\Users\Aluno\Source\Repos\DragonWinterIsComing\DragonWinterIsComing\Views\Pessoas\PaginaPiloto.cshtml"
           Write(item.Usuario);

#line default
#line hidden
            EndContext();
            BeginContext(1444, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1468, 14, false);
#line 43 "C:\Users\Aluno\Source\Repos\DragonWinterIsComing\DragonWinterIsComing\Views\Pessoas\PaginaPiloto.cshtml"
           Write(item.LocOrigem);

#line default
#line hidden
            EndContext();
            BeginContext(1482, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1506, 15, false);
#line 44 "C:\Users\Aluno\Source\Repos\DragonWinterIsComing\DragonWinterIsComing\Views\Pessoas\PaginaPiloto.cshtml"
           Write(item.LocDestino);

#line default
#line hidden
            EndContext();
            BeginContext(1521, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1545, 11, false);
#line 45 "C:\Users\Aluno\Source\Repos\DragonWinterIsComing\DragonWinterIsComing\Views\Pessoas\PaginaPiloto.cshtml"
           Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1556, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1580, 9, false);
#line 46 "C:\Users\Aluno\Source\Repos\DragonWinterIsComing\DragonWinterIsComing\Views\Pessoas\PaginaPiloto.cshtml"
           Write(item.Nota);

#line default
#line hidden
            EndContext();
            BeginContext(1589, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 48 "C:\Users\Aluno\Source\Repos\DragonWinterIsComing\DragonWinterIsComing\Views\Pessoas\PaginaPiloto.cshtml"
        }

#line default
#line hidden
            BeginContext(1622, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Viagem>> Html { get; private set; }
    }
}
#pragma warning restore 1591

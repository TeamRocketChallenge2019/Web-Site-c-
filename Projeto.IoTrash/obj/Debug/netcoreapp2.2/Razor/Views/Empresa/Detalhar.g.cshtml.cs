#pragma checksum "C:\Users\carol\Downloads\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\Empresa\Detalhar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6eca893e81f48023979d1860e39b80df31178354"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empresa_Detalhar), @"mvc.1.0.view", @"/Views/Empresa/Detalhar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Empresa/Detalhar.cshtml", typeof(AspNetCore.Views_Empresa_Detalhar))]
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
#line 1 "C:\Users\carol\Downloads\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\_ViewImports.cshtml"
using Projeto.IoTrash;

#line default
#line hidden
#line 2 "C:\Users\carol\Downloads\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\_ViewImports.cshtml"
using Projeto.IoTrash.Models;

#line default
#line hidden
#line 3 "C:\Users\carol\Downloads\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\_ViewImports.cshtml"
using Projeto.IoTrash.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eca893e81f48023979d1860e39b80df31178354", @"/Views/Empresa/Detalhar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1294986b2be6c9dcf83233591f01a3352b3f3183", @"/Views/_ViewImports.cshtml")]
    public class Views_Empresa_Detalhar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DetalheEmpresaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\carol\Downloads\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\Empresa\Detalhar.cshtml"
  
    ViewData["Title"] = "Detalhar";

#line default
#line hidden
            BeginContext(73, 64, true);
            WriteLiteral("\n<h1>Detalhar</h1>\n\n<h2>Razão Social: <span class=\"text-danger\">");
            EndContext();
            BeginContext(138, 25, false);
#line 9 "C:\Users\carol\Downloads\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\Empresa\Detalhar.cshtml"
                                       Write(Model.Empresa.RazaoSocial);

#line default
#line hidden
            EndContext();
            BeginContext(163, 49, true);
            WriteLiteral("</span></h2>\n<h5>CNPJ: <span class=\"text-danger\">");
            EndContext();
            BeginContext(213, 18, false);
#line 10 "C:\Users\carol\Downloads\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\Empresa\Detalhar.cshtml"
                               Write(Model.Empresa.CNPJ);

#line default
#line hidden
            EndContext();
            BeginContext(231, 52, true);
            WriteLiteral("</span> </h5>\n<h5>E-Mail: <span class=\"text-danger\">");
            EndContext();
            BeginContext(284, 19, false);
#line 11 "C:\Users\carol\Downloads\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\Empresa\Detalhar.cshtml"
                                 Write(Model.Empresa.Email);

#line default
#line hidden
            EndContext();
            BeginContext(303, 53, true);
            WriteLiteral("</span></h5>\n<h5>Telefone: <span class=\"text-danger\">");
            EndContext();
            BeginContext(357, 22, false);
#line 12 "C:\Users\carol\Downloads\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\Empresa\Detalhar.cshtml"
                                   Write(Model.Empresa.Telefone);

#line default
#line hidden
            EndContext();
            BeginContext(379, 54, true);
            WriteLiteral("</span></h5>\n\n\n\n<h2>Caminhões</h2>\n\n<div class=\"row\">\n");
            EndContext();
#line 19 "C:\Users\carol\Downloads\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\Empresa\Detalhar.cshtml"
     foreach (var item in Model.Caminhoes)
    {

#line default
#line hidden
            BeginContext(482, 151, true);
            WriteLiteral("        <div class=\"col-2 mb-2\">\n            <div class=\"card\">\n                <div class=\"card-body\">\n                  Placa:  <p class=\"card-text\">");
            EndContext();
            BeginContext(634, 10, false);
#line 24 "C:\Users\carol\Downloads\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\Empresa\Detalhar.cshtml"
                                          Write(item.Placa);

#line default
#line hidden
            EndContext();
            BeginContext(644, 93, true);
            WriteLiteral(" </p>\n                    <p class=\"card-text\">\n                        Qtd Lixo(Litros): <b>");
            EndContext();
            BeginContext(738, 19, false);
#line 26 "C:\Users\carol\Downloads\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\Empresa\Detalhar.cshtml"
                                        Write(item.QuantidadeLixo);

#line default
#line hidden
            EndContext();
            BeginContext(757, 93, true);
            WriteLiteral("</b><br />\n                       \n\n                </div>\n            </div>\n        </div>\n");
            EndContext();
#line 32 "C:\Users\carol\Downloads\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\Empresa\Detalhar.cshtml"
    }

#line default
#line hidden
            BeginContext(856, 10, true);
            WriteLiteral("</div>\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetalheEmpresaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

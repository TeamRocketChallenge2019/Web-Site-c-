#pragma checksum "F:\2 Ano - 2 Semestre\TesteBoot\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\Caminhao\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f143808e4d14d8bd1d5b9d37f98885ac12108d31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Caminhao_Listar), @"mvc.1.0.view", @"/Views/Caminhao/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Caminhao/Listar.cshtml", typeof(AspNetCore.Views_Caminhao_Listar))]
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
#line 1 "F:\2 Ano - 2 Semestre\TesteBoot\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\_ViewImports.cshtml"
using Projeto.IoTrash;

#line default
#line hidden
#line 2 "F:\2 Ano - 2 Semestre\TesteBoot\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\_ViewImports.cshtml"
using Projeto.IoTrash.Models;

#line default
#line hidden
#line 3 "F:\2 Ano - 2 Semestre\TesteBoot\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\_ViewImports.cshtml"
using Projeto.IoTrash.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f143808e4d14d8bd1d5b9d37f98885ac12108d31", @"/Views/Caminhao/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1294986b2be6c9dcf83233591f01a3352b3f3183", @"/Views/_ViewImports.cshtml")]
    public class Views_Caminhao_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Caminhao>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "pesquisar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "atualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detalhar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "listar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "rota", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "remover", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Projeto.IoTrash.TagHelpers.MensagemTagHelper __Projeto_IoTrash_TagHelpers_MensagemTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "F:\2 Ano - 2 Semestre\TesteBoot\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\Caminhao\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(63, 27, true);
            WriteLiteral("\n<h1>Listar Caminhão</h1>\n\n");
            EndContext();
            BeginContext(90, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("mensagem", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f143808e4d14d8bd1d5b9d37f98885ac12108d317767", async() => {
            }
            );
            __Projeto_IoTrash_TagHelpers_MensagemTagHelper = CreateTagHelper<global::Projeto.IoTrash.TagHelpers.MensagemTagHelper>();
            __tagHelperExecutionContext.Add(__Projeto_IoTrash_TagHelpers_MensagemTagHelper);
            BeginWriteTagHelperAttribute();
#line 9 "F:\2 Ano - 2 Semestre\TesteBoot\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\Caminhao\Listar.cshtml"
     WriteLiteral(TempData["mensagem"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Projeto_IoTrash_TagHelpers_MensagemTagHelper.Texto = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("texto", __Projeto_IoTrash_TagHelpers_MensagemTagHelper.Texto, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(141, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(143, 237, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f143808e4d14d8bd1d5b9d37f98885ac12108d319431", async() => {
                BeginContext(205, 168, true);
                WriteLiteral("\n    <input placeholder=\"Digite a placa\" name=\"termoPesquisa\" type=\"text\" class=\"form-control\" />\n    <input type=\"submit\" value=\"Pesquisar\" class=\"btn btn-success\" />\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(380, 130, true);
            WriteLiteral("\n\n\n<table class=\"table\">\n    <tr>\n        <th>Placa</th>\n        <th>Quantidade de Lixo(Litros)</th>\n        <th></th>\n\n    </tr>\n");
            EndContext();
#line 24 "F:\2 Ano - 2 Semestre\TesteBoot\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\Caminhao\Listar.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(549, 29, true);
            WriteLiteral("        <tr>\n            <td>");
            EndContext();
            BeginContext(579, 10, false);
#line 27 "F:\2 Ano - 2 Semestre\TesteBoot\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\Caminhao\Listar.cshtml"
           Write(item.Placa);

#line default
#line hidden
            EndContext();
            BeginContext(589, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(612, 19, false);
#line 28 "F:\2 Ano - 2 Semestre\TesteBoot\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\Caminhao\Listar.cshtml"
           Write(item.QuantidadeLixo);

#line default
#line hidden
            EndContext();
            BeginContext(631, 39, true);
            WriteLiteral("</td>\n            <td>\n                ");
            EndContext();
            BeginContext(670, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f143808e4d14d8bd1d5b9d37f98885ac12108d3112801", async() => {
                BeginContext(778, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "F:\2 Ano - 2 Semestre\TesteBoot\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\Caminhao\Listar.cshtml"
                     WriteLiteral(item.CaminhaoId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(788, 74, true);
            WriteLiteral("\n                <!-- Botão para acionar modal -->\n                <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 862, "\"", 903, 3);
            WriteAttributeValue("", 872, "codigo.value", 872, 12, true);
            WriteAttributeValue(" ", 884, "=", 885, 2, true);
#line 33 "F:\2 Ano - 2 Semestre\TesteBoot\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\Caminhao\Listar.cshtml"
WriteAttributeValue(" ", 886, item.CaminhaoId, 887, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(904, 158, true);
            WriteLiteral(" class=\"btn btn-danger\" type=\"button\" data-toggle=\"modal\" data-target=\"#modalExemplo\">\n                    Excluir\n                </button>\n\n                ");
            EndContext();
            BeginContext(1062, 173, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f143808e4d14d8bd1d5b9d37f98885ac12108d3116054", async() => {
                BeginContext(1185, 46, true);
                WriteLiteral("\n                    Detalhes\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-codigo", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "F:\2 Ano - 2 Semestre\TesteBoot\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\Caminhao\Listar.cshtml"
                         WriteLiteral(item.CaminhaoId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-codigo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1235, 18, true);
            WriteLiteral("\n\n                ");
            EndContext();
            BeginContext(1253, 204, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f143808e4d14d8bd1d5b9d37f98885ac12108d3118572", async() => {
                BeginContext(1410, 43, true);
                WriteLiteral("\n                    Rotas\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-caminhaoBusca", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "F:\2 Ano - 2 Semestre\TesteBoot\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\Caminhao\Listar.cshtml"
                                WriteLiteral(item.CaminhaoId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["caminhaoBusca"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-caminhaoBusca", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["caminhaoBusca"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1457, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 50 "F:\2 Ano - 2 Semestre\TesteBoot\Web-Site-c--master\Web-Site-c--master\Projeto.IoTrash\Views\Caminhao\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(1496, 706, true);
            WriteLiteral(@"
</table>

<!-- Modal -->
<div class=""modal fade"" id=""modalExemplo"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Confirmação</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Deseja Realmente Excluir?
            </div>
            <div class=""modal-footer"">
                ");
            EndContext();
            BeginContext(2202, 301, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f143808e4d14d8bd1d5b9d37f98885ac12108d3122355", async() => {
                BeginContext(2229, 267, true);
                WriteLiteral(@"
                    <input type=""hidden"" name=""id"" id=""codigo"" />
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
                    <button type=""submit"" class=""btn btn-primary"">Sim</button>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2503, 54, true);
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Caminhao>> Html { get; private set; }
    }
}
#pragma warning restore 1591

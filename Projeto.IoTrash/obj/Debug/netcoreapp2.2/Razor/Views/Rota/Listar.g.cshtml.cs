#pragma checksum "C:\Users\carol\Documents\Fiap\Challange\Projeto.IoTrash\Projeto.IoTrash\Views\Rota\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f7e516642c41d5ca47426ac5a71deffcce7af7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rota_Listar), @"mvc.1.0.view", @"/Views/Rota/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rota/Listar.cshtml", typeof(AspNetCore.Views_Rota_Listar))]
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
#line 1 "C:\Users\carol\Documents\Fiap\Challange\Projeto.IoTrash\Projeto.IoTrash\Views\_ViewImports.cshtml"
using Projeto.IoTrash;

#line default
#line hidden
#line 2 "C:\Users\carol\Documents\Fiap\Challange\Projeto.IoTrash\Projeto.IoTrash\Views\_ViewImports.cshtml"
using Projeto.IoTrash.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f7e516642c41d5ca47426ac5a71deffcce7af7b", @"/Views/Rota/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e54124fb812c73ff13efb6575c1b44947f51c564", @"/Views/_ViewImports.cshtml")]
    public class Views_Rota_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Rota>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "atualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "listar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "lixeira", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "remover", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\carol\Documents\Fiap\Challange\Projeto.IoTrash\Projeto.IoTrash\Views\Rota\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(64, 178, true);
            WriteLiteral("\r\n<h1>Listar</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Dia da Semana</th>\r\n        <th>Descrição Rota</th>\r\n        <th>Caminhão</th>\r\n        <th></th>\r\n\r\n    </tr>\r\n");
            EndContext();
#line 17 "C:\Users\carol\Documents\Fiap\Challange\Projeto.IoTrash\Projeto.IoTrash\Views\Rota\Listar.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(283, 14, true);
            WriteLiteral("<tr>\r\n    <td>");
            EndContext();
            BeginContext(298, 16, false);
#line 20 "C:\Users\carol\Documents\Fiap\Challange\Projeto.IoTrash\Projeto.IoTrash\Views\Rota\Listar.cshtml"
   Write(item.DiaDaSemana);

#line default
#line hidden
            EndContext();
            BeginContext(314, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(330, 18, false);
#line 21 "C:\Users\carol\Documents\Fiap\Challange\Projeto.IoTrash\Projeto.IoTrash\Views\Rota\Listar.cshtml"
   Write(item.DescricaoRota);

#line default
#line hidden
            EndContext();
            BeginContext(348, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(364, 13, false);
#line 22 "C:\Users\carol\Documents\Fiap\Challange\Projeto.IoTrash\Projeto.IoTrash\Views\Rota\Listar.cshtml"
   Write(item.Caminhao);

#line default
#line hidden
            EndContext();
            BeginContext(377, 27, true);
            WriteLiteral("</td>\r\n\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(404, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f7e516642c41d5ca47426ac5a71deffcce7af7b7322", async() => {
                BeginContext(501, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "C:\Users\carol\Documents\Fiap\Challange\Projeto.IoTrash\Projeto.IoTrash\Views\Rota\Listar.cshtml"
             WriteLiteral(item.RotaId);

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
            BeginContext(511, 60, true);
            WriteLiteral("\r\n        <!-- Botão para acionar modal -->\r\n        <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 571, "\"", 608, 3);
            WriteAttributeValue("", 581, "codigo.value", 581, 12, true);
            WriteAttributeValue(" ", 593, "=", 594, 2, true);
#line 28 "C:\Users\carol\Documents\Fiap\Challange\Projeto.IoTrash\Projeto.IoTrash\Views\Rota\Listar.cshtml"
WriteAttributeValue(" ", 595, item.RotaId, 596, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(609, 136, true);
            WriteLiteral(" class=\"btn btn-danger\" type=\"button\" data-toggle=\"modal\" data-target=\"#modalExemplo\">\r\n            Excluir\r\n        </button>\r\n        ");
            EndContext();
            BeginContext(745, 174, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f7e516642c41d5ca47426ac5a71deffcce7af7b10489", async() => {
                BeginContext(883, 32, true);
                WriteLiteral("\r\n            Lixeiras\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-rotaBusca", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 32 "C:\Users\carol\Documents\Fiap\Challange\Projeto.IoTrash\Projeto.IoTrash\Views\Rota\Listar.cshtml"
                    WriteLiteral(item.RotaId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["rotaBusca"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-rotaBusca", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["rotaBusca"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(919, 20, true);
            WriteLiteral("\r\n    </td>\r\n</tr>\r\n");
            EndContext();
#line 38 "C:\Users\carol\Documents\Fiap\Challange\Projeto.IoTrash\Projeto.IoTrash\Views\Rota\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(946, 723, true);
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
            BeginContext(1669, 305, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f7e516642c41d5ca47426ac5a71deffcce7af7b14200", async() => {
                BeginContext(1696, 271, true);
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1974, 56, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Rota>> Html { get; private set; }
    }
}
#pragma warning restore 1591

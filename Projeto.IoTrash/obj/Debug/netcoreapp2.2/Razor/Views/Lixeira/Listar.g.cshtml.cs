#pragma checksum "C:\Users\carol\Documents\Fiap\Challange\Projeto.IoTrash\Projeto.IoTrash\Views\Lixeira\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cd8613a5cde4ece036e3ca220af16b565a7c3e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lixeira_Listar), @"mvc.1.0.view", @"/Views/Lixeira/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Lixeira/Listar.cshtml", typeof(AspNetCore.Views_Lixeira_Listar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cd8613a5cde4ece036e3ca220af16b565a7c3e7", @"/Views/Lixeira/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e54124fb812c73ff13efb6575c1b44947f51c564", @"/Views/_ViewImports.cshtml")]
    public class Views_Lixeira_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Lixeira>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "pesquisar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "atualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\carol\Documents\Fiap\Challange\Projeto.IoTrash\Projeto.IoTrash\Views\Lixeira\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(67, 21, true);
            WriteLiteral("\r\n<h1>Listar</h1>\r\n\r\n");
            EndContext();
            BeginContext(88, 243, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cd8613a5cde4ece036e3ca220af16b565a7c3e75772", async() => {
                BeginContext(150, 174, true);
                WriteLiteral("\r\n    <input placeholder=\"Digite o endereço\" name=\"termoPesquisa\" type=\"text\" class=\"form-control\" />\r\n    <input type=\"submit\" value=\"Pesquisar\" class=\"btn btn-success\" />\r\n");
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
            BeginContext(331, 195, true);
            WriteLiteral("\r\n\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Descrição Lixeira</th>\r\n        <th>Endereço</th>\r\n        <th>Volume Lixo(Litros)</th>\r\n        <th>Rota</th>\r\n        <th></th>\r\n\r\n    </tr>\r\n");
            EndContext();
#line 24 "C:\Users\carol\Documents\Fiap\Challange\Projeto.IoTrash\Projeto.IoTrash\Views\Lixeira\Listar.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(567, 14, true);
            WriteLiteral("<tr>\r\n    <td>");
            EndContext();
            BeginContext(582, 21, false);
#line 27 "C:\Users\carol\Documents\Fiap\Challange\Projeto.IoTrash\Projeto.IoTrash\Views\Lixeira\Listar.cshtml"
   Write(item.DescricaoLixeira);

#line default
#line hidden
            EndContext();
            BeginContext(603, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(619, 13, false);
#line 28 "C:\Users\carol\Documents\Fiap\Challange\Projeto.IoTrash\Projeto.IoTrash\Views\Lixeira\Listar.cshtml"
   Write(item.Endereco);

#line default
#line hidden
            EndContext();
            BeginContext(632, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(648, 15, false);
#line 29 "C:\Users\carol\Documents\Fiap\Challange\Projeto.IoTrash\Projeto.IoTrash\Views\Lixeira\Listar.cshtml"
   Write(item.VolumeLixo);

#line default
#line hidden
            EndContext();
            BeginContext(663, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(679, 9, false);
#line 30 "C:\Users\carol\Documents\Fiap\Challange\Projeto.IoTrash\Projeto.IoTrash\Views\Lixeira\Listar.cshtml"
   Write(item.Rota);

#line default
#line hidden
            EndContext();
            BeginContext(688, 25, true);
            WriteLiteral("</td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(713, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cd8613a5cde4ece036e3ca220af16b565a7c3e79853", async() => {
                BeginContext(813, 6, true);
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
#line 33 "C:\Users\carol\Documents\Fiap\Challange\Projeto.IoTrash\Projeto.IoTrash\Views\Lixeira\Listar.cshtml"
             WriteLiteral(item.LixeiraId);

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
            BeginContext(823, 60, true);
            WriteLiteral("\r\n        <!-- Botão para acionar modal -->\r\n        <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 883, "\"", 923, 3);
            WriteAttributeValue("", 893, "codigo.value", 893, 12, true);
            WriteAttributeValue(" ", 905, "=", 906, 2, true);
#line 35 "C:\Users\carol\Documents\Fiap\Challange\Projeto.IoTrash\Projeto.IoTrash\Views\Lixeira\Listar.cshtml"
WriteAttributeValue(" ", 907, item.LixeiraId, 908, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(924, 146, true);
            WriteLiteral(" class=\"btn btn-danger\" type=\"button\" data-toggle=\"modal\" data-target=\"#modalExemplo\">\r\n            Excluir\r\n        </button>\r\n    </td>\r\n</tr>\r\n");
            EndContext();
#line 40 "C:\Users\carol\Documents\Fiap\Challange\Projeto.IoTrash\Projeto.IoTrash\Views\Lixeira\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(1077, 723, true);
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
            BeginContext(1800, 305, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cd8613a5cde4ece036e3ca220af16b565a7c3e714061", async() => {
                BeginContext(1827, 271, true);
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
            BeginContext(2105, 56, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Lixeira>> Html { get; private set; }
    }
}
#pragma warning restore 1591
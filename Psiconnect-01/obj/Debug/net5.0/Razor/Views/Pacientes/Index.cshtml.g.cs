#pragma checksum "C:\Users\Samuel\OneDrive\Documentos\Faculdade\Projeto\Eixo2\pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial\Psiconnect-01\Views\Pacientes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7f358732d71e9805d8872f8957a4b1eabf8c39e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pacientes_Index), @"mvc.1.0.view", @"/Views/Pacientes/Index.cshtml")]
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
#line 1 "C:\Users\Samuel\OneDrive\Documentos\Faculdade\Projeto\Eixo2\pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial\Psiconnect-01\Views\_ViewImports.cshtml"
using Psiconnect_01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Samuel\OneDrive\Documentos\Faculdade\Projeto\Eixo2\pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial\Psiconnect-01\Views\_ViewImports.cshtml"
using Psiconnect_01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7f358732d71e9805d8872f8957a4b1eabf8c39e", @"/Views/Pacientes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f95e059f4e516f6d556fe6b3ee54aef56cf9e3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Pacientes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Psiconnect_01.Models.Paciente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary float-sm-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Samuel\OneDrive\Documentos\Faculdade\Projeto\Eixo2\pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial\Psiconnect-01\Views\Pacientes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7f358732d71e9805d8872f8957a4b1eabf8c39e4332", async() => {
                WriteLiteral("Novo Paciente");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<br /><br />\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Samuel\OneDrive\Documentos\Faculdade\Projeto\Eixo2\pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial\Psiconnect-01\Views\Pacientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Samuel\OneDrive\Documentos\Faculdade\Projeto\Eixo2\pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial\Psiconnect-01\Views\Pacientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <!--\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Samuel\OneDrive\Documentos\Faculdade\Projeto\Eixo2\pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial\Psiconnect-01\Views\Pacientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\Samuel\OneDrive\Documentos\Faculdade\Projeto\Eixo2\pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial\Psiconnect-01\Views\Pacientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\Samuel\OneDrive\Documentos\Faculdade\Projeto\Eixo2\pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial\Psiconnect-01\Views\Pacientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cep));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\Samuel\OneDrive\Documentos\Faculdade\Projeto\Eixo2\pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial\Psiconnect-01\Views\Pacientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Endereço));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\Samuel\OneDrive\Documentos\Faculdade\Projeto\Eixo2\pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial\Psiconnect-01\Views\Pacientes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bairro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            -->\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 42 "C:\Users\Samuel\OneDrive\Documentos\Faculdade\Projeto\Eixo2\pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial\Psiconnect-01\Views\Pacientes\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\Samuel\OneDrive\Documentos\Faculdade\Projeto\Eixo2\pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial\Psiconnect-01\Views\Pacientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\Samuel\OneDrive\Documentos\Faculdade\Projeto\Eixo2\pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial\Psiconnect-01\Views\Pacientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <!--\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\Samuel\OneDrive\Documentos\Faculdade\Projeto\Eixo2\pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial\Psiconnect-01\Views\Pacientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\Samuel\OneDrive\Documentos\Faculdade\Projeto\Eixo2\pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial\Psiconnect-01\Views\Pacientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\Samuel\OneDrive\Documentos\Faculdade\Projeto\Eixo2\pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial\Psiconnect-01\Views\Pacientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cep));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\Samuel\OneDrive\Documentos\Faculdade\Projeto\Eixo2\pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial\Psiconnect-01\Views\Pacientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Endereço));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\Samuel\OneDrive\Documentos\Faculdade\Projeto\Eixo2\pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial\Psiconnect-01\Views\Pacientes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bairro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            -->\r\n        \r\n        </tr>\r\n");
#nullable restore
#line 69 "C:\Users\Samuel\OneDrive\Documentos\Faculdade\Projeto\Eixo2\pmv-ads-2022-1-e2-proj-int-t6-atencao_psicossocial\Psiconnect-01\Views\Pacientes\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Psiconnect_01.Models.Paciente>> Html { get; private set; }
    }
}
#pragma warning restore 1591

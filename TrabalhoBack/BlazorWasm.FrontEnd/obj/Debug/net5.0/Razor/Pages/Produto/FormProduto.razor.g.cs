#pragma checksum "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\FormProduto.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a376e7dcc73f1a589a211060d9d566292403d5c7"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWasm.FrontEnd.Pages.Produto
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.FrontEnd.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.FrontEnd.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.FrontEnd.Repositorio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasmServer.Client.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using BlazorWasm.Compartilhado.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    public partial class FormProduto : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>FormProduto</h3>\r\n\r\n\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\FormProduto.razor"
                 Produto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\FormProduto.razor"
                                         OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\t");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "<label>Nome:</label>\r\n\t\t");
                __builder2.OpenElement(10, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "class", "form-control");
                __builder2.AddAttribute(13, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\FormProduto.razor"
                                                          Produto.Nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Produto.Nome = __value, Produto.Nome))));
                __builder2.AddAttribute(15, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Produto.Nome));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n\t\t\t");
                __Blazor.BlazorWasm.FrontEnd.Pages.Produto.FormProduto.TypeInference.CreateValidationMessage_0(__builder2, 17, 18, 
#nullable restore
#line 12 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\FormProduto.razor"
                                    (() =>Produto.Nome)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n\t\t");
                __builder2.AddMarkupContent(20, "<label>Preço:</label>\r\n\t\t");
                __builder2.OpenElement(21, "div");
                __Blazor.BlazorWasm.FrontEnd.Pages.Produto.FormProduto.TypeInference.CreateInputNumber_1(__builder2, 22, 23, "form-control", 24, 
#nullable restore
#line 16 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\FormProduto.razor"
                                                            Produto.Preco

#line default
#line hidden
#nullable disable
                , 25, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Produto.Preco = __value, Produto.Preco)), 26, () => Produto.Preco);
                __builder2.AddMarkupContent(27, "\r\n\t\t\t");
                __Blazor.BlazorWasm.FrontEnd.Pages.Produto.FormProduto.TypeInference.CreateValidationMessage_2(__builder2, 28, 29, 
#nullable restore
#line 17 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\FormProduto.razor"
                                    (() =>Produto.Nome)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n\t\t");
                __builder2.AddMarkupContent(31, "<label>Descrição:</label>\r\n\t\t");
                __builder2.OpenElement(32, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(33);
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\FormProduto.razor"
                                                          Produto.Descricao

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Produto.Descricao = __value, Produto.Descricao))));
                __builder2.AddAttribute(37, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Produto.Descricao));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n\t\t\t");
                __Blazor.BlazorWasm.FrontEnd.Pages.Produto.FormProduto.TypeInference.CreateValidationMessage_3(__builder2, 39, 40, 
#nullable restore
#line 22 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\FormProduto.razor"
                                    (() =>Produto.Nome)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n\t\t   ");
                __builder2.AddMarkupContent(42, "<label>Categoria:</label>\r\n\t\t");
                __builder2.OpenElement(43, "div");
                __builder2.OpenElement(44, "select");
                __builder2.AddAttribute(45, "name", "cat");
                __builder2.AddAttribute(46, "id", "cat");
                __builder2.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\FormProduto.razor"
                                               Produto.CategoriaId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Produto.CategoriaId = __value, Produto.CategoriaId));
                __builder2.SetUpdatesAttributeName("value");
#nullable restore
#line 27 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\FormProduto.razor"
                 if (Categorias is not null)
				{
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\FormProduto.razor"
                     if (Categorias.Count > 0)
					{
						foreach (Categoria item_context in Categorias)
						{

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(49, "option");
                __builder2.AddAttribute(50, "value", 
#nullable restore
#line 33 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\FormProduto.razor"
                                            item_context.Id

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 33 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\FormProduto.razor"
__builder2.AddContent(51, item_context.Nome);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 34 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\FormProduto.razor"
						}
					}

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\FormProduto.razor"
                     

				}

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\t\r\n\t");
                __builder2.AddMarkupContent(53, "<button class=\"btn btn-success\" type=\"submit\">Salvar</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\FormProduto.razor"
       
	[Parameter] public Produto Produto { get; set; }
	[Parameter] public EventCallback OnValidSubmit { get; set; }
	[Parameter] public List<Categoria> Categorias { get; set; }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorWasm.FrontEnd.Pages.Produto.FormProduto
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

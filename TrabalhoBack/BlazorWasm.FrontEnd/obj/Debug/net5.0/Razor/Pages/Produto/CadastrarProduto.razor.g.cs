#pragma checksum "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\CadastrarProduto.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b2f053245f2e0f4cee1da73fe76f6d723b0c2e9"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/produto/cadastro")]
    public partial class CadastrarProduto : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Cadastrar Produto</h3>");
#nullable restore
#line 8 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\CadastrarProduto.razor"
 if (_categorias is not null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorWasm.FrontEnd.Pages.Produto.FormProduto>(1);
            __builder.AddAttribute(2, "Produto", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorWasm.Compartilhado.Entidades.Produto>(
#nullable restore
#line 10 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\CadastrarProduto.razor"
                          produto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 10 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\CadastrarProduto.razor"
                                                  Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "Categorias", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorWasm.Compartilhado.Entidades.Categoria>>(
#nullable restore
#line 10 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\CadastrarProduto.razor"
                                                                      _categorias

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 11 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\CadastrarProduto.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Produto\CadastrarProduto.razor"
       
	private Produto produto = new Produto();
	private List<Categoria> _categorias;

	protected override async Task OnInitializedAsync()
	{
		_categorias = await repositoryCategoria.Get();
	}

	private async Task Create()
	{
		try
		{
			await repository.Add(produto);
			navigationManager.NavigateTo("produto");
		}
		catch (Exception ex)
		{
			Console.WriteLine("Error: " + ex.Message);
		}
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository<Categoria> repositoryCategoria { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository<Produto> repository { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Categoria\CadastrarCategoria.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74a07877376a234be219cad45cc1851eaa3ad662"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWasm.FrontEnd.Pages.Categoria
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/categoria/cadastro")]
    public partial class CadastrarCategoria : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Cadastro Categoria</h3>\r\n\r\n");
            __builder.OpenComponent<BlazorWasm.FrontEnd.Pages.Categoria.FormCategoria>(1);
            __builder.AddAttribute(2, "Categoria", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorWasm.Compartilhado.Entidades.Categoria>(
#nullable restore
#line 7 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Categoria\CadastrarCategoria.razor"
                          categoria

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 7 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Categoria\CadastrarCategoria.razor"
                                                    Create

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Pages\Categoria\CadastrarCategoria.razor"
       
    private Categoria categoria = new Categoria();

    private async Task Create()
    {
            await repository.Add(categoria);

            navigationManager.NavigateTo("categoria");  
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository<Categoria> repository { get; set; }
    }
}
#pragma warning restore 1591
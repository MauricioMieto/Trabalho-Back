#pragma checksum "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Shared\InputImg.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06b6af7edc88e8367ddfe2b0b2371e0446920ca7"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWasm.FrontEnd.Shared
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
    public partial class InputImg : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "label");
#nullable restore
#line 2 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Shared\InputImg.razor"
__builder.AddContent(2, Label);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(5);
            __builder.AddAttribute(6, "accept", ".jpg,.jpeg,.png");
            __builder.AddAttribute(7, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 4 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Shared\InputImg.razor"
                                                      OnChange

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n\n");
            __builder.OpenElement(9, "div");
#nullable restore
#line 9 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Shared\InputImg.razor"
     if (imageBase64 != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "div");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "style", "margin:10px");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", "data:image/jpeg;base64," + " " + (
#nullable restore
#line 13 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Shared\InputImg.razor"
                                           imageBase64

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "style", "width: 400px;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 15 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Shared\InputImg.razor"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Shared\InputImg.razor"
     if (ImageURL != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "div");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "style", "margin:10px");
            __builder.OpenElement(19, "img");
            __builder.AddAttribute(20, "src", 
#nullable restore
#line 20 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Shared\InputImg.razor"
                   ImageURL

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "style", "width: 400px;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Shared\InputImg.razor"
      }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "D:\Downloads\TrabalhoBack\BlazorWasm.FrontEnd\Shared\InputImg.razor"
        [Parameter] public string Label { get; set; } = "Image";
    [Parameter] public EventCallback<string> OnSelectedImage { get; set; }
    [Parameter] public string ImageURL { get; set; }
    private string imageBase64;

    //oneImg
    async Task OnChange(InputFileChangeEventArgs e)
    {
        var imageFile = e.File ;

        var buffer = new byte[imageFile.Size];
        await imageFile.OpenReadStream().ReadAsync(buffer);
        imageBase64 = Convert.ToBase64String(buffer);
        await OnSelectedImage.InvokeAsync(imageBase64);
        ImageURL = null;
        StateHasChanged();

    }





#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SMTOWEB.Pages.AdminMTO.Tarjetas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTO_API.Modelos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Servicios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Pages.global;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Pages.VendedoresMTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Modelo_Reporte;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Modelo_Response;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\_Imports.razor"
using SMTOWEB.Pages.AdminMTO.Empresas.Sucursales;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tarjetas")]
    public partial class Tarjetas_home : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "C:\Users\yunior.moreta.G4S\source\repos\SMTO-WEB\SMTOWEB\Pages\AdminMTO\Tarjetas\Tarjetas-home.razor"
       

    List<Tarjeta> tarjetas;
    RadzenDataGrid<Tarjeta> grid;
    public bool loading { get; set; }
    protected override async Task OnInitializedAsync()
    {
        try
        {
            var response = await http.GetFromJsonAsync<ResponseCardAdd>($"https://localhost:44391/api/Tarjetas");
            tarjetas = response.tarjeta;
        }
        catch (Exception)
        {

        }
    }

    async Task OnChange(bool estado, string tipo, Tarjeta tarjeta)
    {
        var result = await Js.InvokeAsync<bool>
           ("confirmarEliminacion", "Precaucion", $"¿Estas seguro que quieres {tipo} la tarjeta?", "warning", "Si");

        if (result)
        {
            await CambiarEstadoTarjeta(tarjeta);
        }
        else
        {
            tarjeta.Estado = !tarjeta.Estado;
        }
    }
    async Task ConfirmarEliminacionCard(Tarjeta tarjeta)
    {
        var result = await Js.InvokeAsync<bool>
           ("confirmarEliminacion", "Precaucion", $"¿Estas seguro que quieres eliminar la tarjeta?", "warning", "Si");

        if (result)
        {
            await DeleteCard(tarjeta);
        }

    }

    async Task DeleteCard(Tarjeta tarjeta)
    {

        loading = true;

        var delete = await http.DeleteAsync($"https://localhost:44391/api/Tarjetas/{tarjeta.IdTarjeta}");
        var respuesta = await delete.Content.ReadFromJsonAsync<ResponseCardAdd>();
        if (respuesta.ok)
        {
            tarjetas.Remove(tarjeta);
            loading = false;
            await Js.InvokeAsync<object>
            ("Estado", "Exito", $"{respuesta.mensaje}", "success");

        }
        else
        {
            loading = false;
            await Js.InvokeAsync<object>("Estado", "Oops..", $"{respuesta.mensaje}", "error");
        }
        await grid.Reload();
    }

    async Task CambiarEstadoTarjeta(Tarjeta tarjeta)
    {
        loading = true;
        string json = JsonConvert.SerializeObject(tarjeta);
        StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
        var responses = await http.PutAsync($"https://localhost:44391/api/Tarjetas/{tarjeta.IdTarjeta}", httpContent);
        var respuesta = await responses.Content.ReadFromJsonAsync<ResponseCardAdd>();
        if (respuesta.ok)
        {
            loading = false;
            await Js.InvokeAsync<object>
            ("Estado", "Exito", $"{(tarjeta.Estado == true ? "La tarjeta a sido activada exitosamente..." : "La tarjeta a sido desactivada exitosamente...")}", "success");
        }
        else
        {
            loading = false;
            await Js.InvokeAsync<object>("Estado", "Oops..", $"{respuesta.mensaje}", "error");
        }
    }

    public class ResponseCardAdd
    {
        public bool ok { get; set; }
        public string? mensaje { get; set; }
        public List<Tarjeta>? tarjeta { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigate { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591

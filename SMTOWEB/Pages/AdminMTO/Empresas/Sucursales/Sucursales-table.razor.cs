using Microsoft.JSInterop;
using Newtonsoft.Json;
using Radzen.Blazor;
using SMTO_API.Modelos;
using SMTOWEB.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SMTOWEB.Pages.AdminMTO.Empresas.Sucursales
{
    public partial class Sucursales_table
    {
        private UserTemp user;
        CallAlerts alerts = new CallAlerts();
        Empresa empresa;
        List<Sucursal> sucursals;
        CustomUsuarios customUsuarios;
        RadzenDataGrid<Sucursal> grid;
        protected override async Task OnInitializedAsync()
        {
            try
            {
                user = await sessionStorage.GetItemAsync<UserTemp>("usuario");
                if (user != null)
                {
                    empresa = await http.GetFromJsonAsync<Empresa>($"https://localhost:44391/api/Empresas/idUsuario/{user.idUsuario}");
                    if (empresa != null)
                    {
                        await GetSucursales();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        async Task GetSucursales()
        {
            sucursals = await http.GetFromJsonAsync<List<Sucursal>>
                ($"https://localhost:44391/api/Sucursal/info/sucursal/empresa/{empresa.IdEmpresa}");
        }

        async Task ConfirmarEliminacionSucursal(Sucursal sucursal)
        {
            var result = await Js.InvokeAsync<bool>
                ("confirmarEliminacion", "Precaucion", "¿Estas seguro que quieres eliminar la sucursal?", "warning", "Si");

            if (result)
            {
                await EliminarSucursal(sucursal);
            }
        }

        async Task OnChange(bool? value, string tipo, Sucursal sucursal)
        {
            var result = await Js.InvokeAsync<bool>
               ("confirmarEliminacion", "Precaucion", $"¿Estas seguro que quieres {tipo} la sucursal?", "warning", "Si");

            if (result)
            {
                await CambiarEstadoSucursal(sucursal);
            }
            else
            {
                sucursal.Estado =! sucursal.Estado;
            }
        }

        async Task CambiarEstadoSucursal(Sucursal sucursal)
        {
            string json = JsonConvert.SerializeObject(sucursal);
            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responses = await http.PutAsync($"https://localhost:44391/api/Sucursal/{sucursal.IdSucursal}", httpContent);
            var respuesta = await responses.Content.ReadFromJsonAsync<CustomSucursales>();
            if (respuesta.Ok)
            {
                await Js.InvokeAsync<object>
                    ("Estado", "Exito", $"{(sucursal.Estado == true ? "La sucursal a sido activada exitosamente..." : "La sucursal a sido desactivada exitosamente...")}", "success");
            }
            else
            {
                await Js.InvokeAsync<object>("Estado", "Oops..", $"{respuesta.Mensaje}", "error");
            }
        }

        async Task EliminarSucursal(Sucursal sucursal)
        {
            var result = await http.DeleteAsync($"https://localhost:44391/api/Sucursal/{sucursal.IdSucursal}");
            var response = await result.Content.ReadFromJsonAsync<CustomSucursales>();
            if (response.Ok)
            {
                sucursals.Remove(sucursal);
                await Js.InvokeAsync<object>("Estado", "Exito", $"{response.Mensaje}", "success");
                await grid.Reload();
            }
            else
            {
                await Js.InvokeAsync<object>("Estado", "Oops..", $"{response.Mensaje}", "error");
            }
        }

        class CustomSucursales
        {
            public bool Ok { get; set; }
            public string Mensaje { get; set; }
            public List<Sucursal>? Sucursal { get; set; }
        }
    }
}

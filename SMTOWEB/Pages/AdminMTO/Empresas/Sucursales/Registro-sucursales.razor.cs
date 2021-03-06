using Microsoft.AspNetCore.Components;
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
    public partial class Registro_sucursales
    {
        [Parameter]
        public int id { get; set; }
        [Parameter]
        public int ids { get; set; }

        private UserTemp user;
        Sucursal sucursal = new Sucursal();
        List<Usuario> usuarios;
        CustomUsuarios customUsuarios;
        RadzenDataGrid<Usuario> grid;
        BalanceSucursal balanceSucursal = new BalanceSucursal();
        CustomBalanceSucursales customBalanceSucursales;
        protected override async Task OnInitializedAsync()
        {
            try
            {
                user = await sessionStorage.GetItemAsync<UserTemp>("usuario");
                if (user != null)
                {
                    if (ids !=0)
                    {
                        await GetSucursal();
                        await GetUsuarios();
                        await GetBalanceSucursal();
                    }
                }
            }
            catch (Exception)
            {

            }
        }


        async Task GetUsuarios()
        {
            customUsuarios = await http.GetFromJsonAsync<CustomUsuarios>($"https://smto-apiv2.azurewebsites.net/api/Usuarios/sucursal/{ids}");
            if (customUsuarios.Ok)
            {
                usuarios = customUsuarios.Usuarios;
            }
        }

        async Task GetSucursal()
        {
            sucursal = await http.GetFromJsonAsync<Sucursal>($"https://smto-apiv2.azurewebsites.net/api/Sucursal/{ids}");
        }


        async Task GetBalanceSucursal()
        {
            customBalanceSucursales  = await http.GetFromJsonAsync<CustomBalanceSucursales>($"https://smto-apiv2.azurewebsites.net/api/BalanceSucursal/{ids}");
        }

        async Task PostSucursal()
        {
            if (ids ==0)
            {
                var fecha = DateTime.Now.ToString("yyyy-MM-ddThh:mm:ss");
                sucursal.FechaCreacion = Convert.ToDateTime(fecha);
                sucursal.IdEmpresa = id;
                sucursal.Estado = true;
                sucursal.IdUsuario = user.idUsuario;
                string json = JsonConvert.SerializeObject(sucursal);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var responses = await http.PostAsync("https://smto-apiv2.azurewebsites.net/api/Sucursal", httpContent);
                var respuesta = await responses.Content.ReadFromJsonAsync<CustomSucursales>();
                if (respuesta.Ok)
                {
                    await Js.InvokeAsync<object>("Estado", "Éxito", $"{respuesta.Mensaje}", "success");
                    sucursal = new Sucursal();
                }
                else
                {
                    await Js.InvokeAsync<object>("Estado", "Oops..", $"{respuesta.Mensaje}", "error");
                }
            }
            else
            {
               
                string json = JsonConvert.SerializeObject(sucursal);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var responses = await http.PutAsync($"https://smto-apiv2.azurewebsites.net/api/Sucursal/{sucursal.IdSucursal}", httpContent);
                var respuesta = await responses.Content.ReadFromJsonAsync<CustomSucursales>();
                if (respuesta.Ok)
                {
                    await Js.InvokeAsync<object>("Estado", "Éxito", $"{respuesta.Mensaje}", "success");
                }
                else
                {
                    await Js.InvokeAsync<object>("Estado", "Oops..", $"{respuesta.Mensaje}", "error");
                }
            }
        }

        async Task RecargarSucursal()
        {
            balanceSucursal.IdEmpresa = id;
            balanceSucursal.IdSucursal = sucursal.IdSucursal;
            balanceSucursal.IdUsuario = user.idUsuario;
            string json = JsonConvert.SerializeObject(balanceSucursal);
            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responses = await http.PostAsync("https://smto-apiv2.azurewebsites.net/api/BalanceSucursal", httpContent);
            var respuesta = await responses.Content.ReadFromJsonAsync<CustomBalanceSucursales>();
            if (respuesta.Ok)
            {
                await Js.InvokeAsync<object>("Estado", "Éxito", $"{respuesta.Mensaje}", "success");
                await GetBalanceSucursal();
                balanceSucursal = new BalanceSucursal();
            }
            else
            {
                await UpdateRecargarSucursal(respuesta.BalanceSucursal[0]);
            }
        }

        async Task UpdateRecargarSucursal(BalanceSucursal NbalanceSucursal)
        {
            var fecha = DateTime.Now.ToString("yyyy-MM-ddThh:mm:ss");
            NbalanceSucursal.FechaActualizacion = Convert.ToDateTime(fecha);
            NbalanceSucursal.Balance = balanceSucursal.Balance;
            string json = JsonConvert.SerializeObject(NbalanceSucursal);
            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responses = await http.PutAsync($"https://smto-apiv2.azurewebsites.net/api/BalanceSucursal/{ids}", httpContent);
            var respuesta = await responses.Content.ReadFromJsonAsync<CustomBalanceSucursales>();
            if (respuesta.Ok)
            {
                await Js.InvokeAsync<object>("Estado", "Éxito", $"{respuesta.Mensaje}", "success");
                await GetBalanceSucursal();
                balanceSucursal = new BalanceSucursal();
            }
            else
            {
                await Js.InvokeAsync<object>("Estado", "Oops..", $"{respuesta.Mensaje}", "error");
            }
        }



        class CustomSucursales
        {
            public bool Ok { get; set; }
            public string Mensaje { get; set; }
            public List<Sucursal> Sucursal { get; set; }
        }

        class CustomBalanceSucursales
        {
            public bool Ok { get; set; }
            public string Mensaje { get; set; }
            public List<BalanceSucursal> BalanceSucursal { get; set; }
        }
    }
}

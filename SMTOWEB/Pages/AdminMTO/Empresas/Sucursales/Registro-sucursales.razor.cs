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
                    }
                }
            }
            catch (Exception)
            {

            }
        }


        async Task GetUsuarios()
        {
            customUsuarios = await http.GetFromJsonAsync<CustomUsuarios>($"https://localhost:44391/api/Usuarios/sucursal/{ids}");
            if (customUsuarios.Ok)
            {
                usuarios = customUsuarios.Usuarios;
            }
        }

        async Task GetSucursal()
        {
            sucursal = await http.GetFromJsonAsync<Sucursal>($"https://localhost:44391/api/Sucursal/{ids}");
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
                var responses = await http.PostAsync("https://localhost:44391/api/Sucursal", httpContent);
                var respuesta = await responses.Content.ReadFromJsonAsync<CustomSucursales>();
                if (respuesta.Ok)
                {
                    await Js.InvokeAsync<object>("Estado", "Exito", $"{respuesta.Mensaje}", "success");
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
                var responses = await http.PutAsync($"https://localhost:44391/api/Sucursal/{sucursal.IdSucursal}", httpContent);
                var respuesta = await responses.Content.ReadFromJsonAsync<CustomSucursales>();
                if (respuesta.Ok)
                {
                    await Js.InvokeAsync<object>("Estado", "Exito", $"{respuesta.Mensaje}", "success");
                }
                else
                {
                    await Js.InvokeAsync<object>("Estado", "Oops..", $"{respuesta.Mensaje}", "error");
                }
            }
        }

        class CustomSucursales
        {
            public bool Ok { get; set; }
            public string Mensaje { get; set; }
            public List<Sucursal> Sucursal { get; set; }
        }
    }
}

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using SMTO_API.Modelos;
using SMTOWEB.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SMTOWEB.Pages.AdminMTO.Empresas
{
    public partial class Empresas_page_view
    {
        Empresa empresa = new Empresa();
        List<Usuario> usuarios;
        GetUsuariosServices usuariosServices = new();
        Usuario usuario;
        [Parameter]
        public int IdEmpresa { get; set; }
        public bool loading { get; set; }
        protected override async Task OnInitializedAsync()
        {
            try
            {
                loading = true;
                usuarios = await usuariosServices.GetUsuarios();
                empresa = await http.GetFromJsonAsync<Empresa>($"https://smto-apiv2.azurewebsites.net/api/Empresas/{IdEmpresa}");
                if (empresa.Nombre != null)
                {
                    await GetTask();
                }
            }
            catch (Exception)
            {
                loading = false;
                usuarios = new List<Usuario>();
            }
        }

        async Task GetTask()
        {
            usuario = await http.GetFromJsonAsync<Usuario>($"https://smto-apiv2.azurewebsites.net/api/Usuarios/{empresa.IdUsuario}");
            if (usuario != null)
            {
                loading = false;
            }
        }

        async Task UpdateEmpresa()
        {
            loading = true;
            string json = JsonConvert.SerializeObject(empresa);
            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responses = await http.PutAsync($"https://smto-apiv2.azurewebsites.net/api/Empresas/{IdEmpresa}", httpContent);
            var respuesta = await responses.Content.ReadFromJsonAsync<CustomEmpresas>();
            if (respuesta.Ok)
            {
                loading = false;
                await Js.InvokeAsync<object>("Estado", "Éxito", $"{respuesta.Mensaje}", "success");
                await GetTask();
            }
            else
            {
                loading = false;
                await Js.InvokeAsync<object>("Estado", "Oops..", $"{respuesta.Mensaje}", "error");
            }
        }

        async Task OnChange( string tipo, Empresa empresa)
        {
            var result = await Js.InvokeAsync<bool>
               ("confirmarEliminacion", "Precaución", $"¿Estas seguro que quieres {tipo} la empresa?", "warning", "Si");

            if (result)
            {
                await CambiarEstadoEmpresa(empresa);
            }
        
        }

        async Task CambiarEstadoEmpresa(Empresa empresa)
        {
            empresa.Estado =! empresa.Estado;
            string json = JsonConvert.SerializeObject(empresa);
            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responses = await http.PutAsync($"https://smto-apiv2.azurewebsites.net/api/Empresas/{IdEmpresa}", httpContent);
            var respuesta = await responses.Content.ReadFromJsonAsync<CustomEmpresas>();
            if (respuesta.Ok)
            {
                await Js.InvokeAsync<object>
                    ("Estado", "Éxito", $"{(empresa.Estado == true ? "La empresa a sido activada exitosamente..." : "La empresa a sido desactivada exitosamente...")}", "success");
            }
            else
            {
                await Js.InvokeAsync<object>("Estado", "Oops..", $"{respuesta.Mensaje}", "error");
            }
        }

        class CustomEmpresas
        {
            public bool Ok { get; set; }
            public string Mensaje { get; set; }
        }
    }
}

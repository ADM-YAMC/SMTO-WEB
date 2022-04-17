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
                empresa = await http.GetFromJsonAsync<Empresa>($"https://localhost:44391/api/Empresas/{IdEmpresa}");
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
            usuario = await http.GetFromJsonAsync<Usuario>($"https://localhost:44391/api/Usuarios/{empresa.IdUsuario}");
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
            var responses = await http.PutAsync($"https://localhost:44391/api/Empresas/{IdEmpresa}", httpContent);
            var respuesta = await responses.Content.ReadFromJsonAsync<CustomEmpresas>();
            if (respuesta.Ok)
            {
                loading = false;
                await Js.InvokeAsync<object>("Estado", "Exito", $"{respuesta.Mensaje}", "success");
                await GetTask();
            }
            else
            {
                loading = false;
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

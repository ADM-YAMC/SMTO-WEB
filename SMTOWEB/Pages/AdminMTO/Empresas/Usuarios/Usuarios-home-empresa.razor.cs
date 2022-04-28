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

namespace SMTOWEB.Pages.AdminMTO.Empresas.Usuarios
{
    public partial class Usuarios_home_empresa
    {
       
        private UserTemp user;
        CallAlerts alerts = new CallAlerts();
        Empresa empresa;
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
                    empresa = await http.GetFromJsonAsync<Empresa>($"https://smto-apiv2.azurewebsites.net/api/Empresas/idUsuario/{user.idUsuario}");
                    if (empresa != null)
                    {
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
            customUsuarios = await http.GetFromJsonAsync<CustomUsuarios>($"https://smto-apiv2.azurewebsites.net/api/Usuarios/empresa/{empresa.IdEmpresa}");
            if (customUsuarios.Ok)
            {
                usuarios = customUsuarios.Usuarios;
            }
        }


        async Task ConfirmarDesvinculacion(Usuario usuario)
        {
            var result = await Js.InvokeAsync<bool>
                ("confirmarEliminacion", "Precaución", "¿Estas seguro que quieres desvincular a este usuario?", "warning","Si");

            if (result)
            {
                await Desvincular(usuario);
            }
        }

        async Task Desvincular(Usuario usuario)
        {
            usuario.IdEmpresa = 0;
            usuario.IdSucursal = 0;
            usuario.Rol = "4";
            string json = JsonConvert.SerializeObject(usuario);
            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responses = await http.PutAsync($"https://smto-apiv2.azurewebsites.net/api/Usuarios/{usuario.IdUsuario}", httpContent);
            var respuesta = await responses.Content.ReadFromJsonAsync<CustomUsuarios>();
            if (respuesta.Ok)
            {
                await Js.InvokeAsync<object>("Estado", "Éxito", $"El usuario a sido desvinculado con Éxito...", "success");
                await GetUsuarios();
                await grid.Reload();
            }
            else
            {
                await Js.InvokeAsync<object>("Estado", "Oops..", $"{respuesta.Mensaje}", "error");
            }
        }
    }
}

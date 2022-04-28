using Microsoft.JSInterop;
using Newtonsoft.Json;
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
    public partial class Registro_usuario
    {
        Usuario usuario = new Usuario();
        private UserTemp user;
        CallAlerts alerts = new CallAlerts();
        Empresa empresa;
        List<Sucursal> sucursales;
        CustomUsuarios customUsuarios;
        CustomUsuarios respuesta;
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
                        sucursales = await http.GetFromJsonAsync<List<Sucursal>>($"https://smto-apiv2.azurewebsites.net/api/Sucursal/info/sucursal/empresa/{empresa.IdEmpresa}");
                    }
                }
            }
            catch (Exception)
            {
               
            }
        }

        async Task BuscarPorCedula(string cedula)
        {
            customUsuarios = await http.GetFromJsonAsync<CustomUsuarios>($"https://smto-apiv2.azurewebsites.net/api/Usuarios/cedula/{cedula}");
            if (customUsuarios.Ok)
            {
                usuario = customUsuarios.Usuarios[0];
                usuario.Rol = null;
                usuario.IdSucursal = null;
            }
            else
            {
                var cedulaTemp = usuario.Cedula;
                usuario = new Usuario();
                usuario.Cedula = cedulaTemp;
            }
        }

        async Task PostUser()
        {
            if (!customUsuarios.Ok)
            {
                var fecha = DateTime.Now.ToString("yyyy-MM-ddThh:mm:ss");
                usuario.FechaCreacion = Convert.ToDateTime(fecha);
                usuario.Contraseña = "12345678";
                usuario.IdEmpresa = empresa.IdEmpresa;
                string json = JsonConvert.SerializeObject(usuario);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var responses = await http.PostAsync("https://smto-apiv2.azurewebsites.net/api/Usuarios", httpContent);
               var respuesta = await responses.Content.ReadFromJsonAsync<CustomUsuarios>();
                if (respuesta.Ok)
                {
                    await Js.InvokeAsync<object>("Estado", "Éxito", $"{respuesta.Mensaje}", "success");
                    usuario = new Usuario();
                }
                else
                {
                    await Js.InvokeAsync<object>("Estado", "Oops..", $"{respuesta.Mensaje}", "error");
                }
            }
            else
            {
                usuario.IdEmpresa = empresa.IdEmpresa;
                string json = JsonConvert.SerializeObject(usuario);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var responses = await http.PutAsync($"https://smto-apiv2.azurewebsites.net/api/Usuarios/{usuario.IdUsuario}", httpContent);
                var  respuesta = await responses.Content.ReadFromJsonAsync<CustomUsuarios>();
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

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {

            if (firstRender)
            {
                try
                {
                    var storage = await Js.InvokeAsync<string>("Session");
                    user = JsonConvert.DeserializeObject<UserTemp>(storage);
                    StateHasChanged();
                }
                catch (Exception)
                {

                    Console.WriteLine("Error");
                    user = null;
                }
            }
        }

        class CustomUsuarios
        {
            public bool Ok { get; set; }
            public string Mensaje { get; set; }
            public List<Usuario>? Usuarios { get; set; }
        }
        public class Response
        {
            public bool ok { get; set; }
        }
    }
}

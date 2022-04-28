using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
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

namespace SMTOWEB.Pages.global
{
    public partial class AddUser
    {
        
        Usuario usuario = new Usuario();
        private Response respuesta;
        private UserTemp user;
        CallAlerts alerts = new CallAlerts();


        protected override async Task OnInitializedAsync()
        {
            usuario.Rol = "4";
            usuario.IdSucursal = 0;
        }
        async Task PostUser()
        {
            usuario.IdEmpresa = 0;
            usuario.Estado = true;
            if (user == null){usuario.Rol = "4";}
            var fecha = DateTime.Now.ToString("yyyy-MM-ddThh:mm:ss");
            usuario.FechaCreacion = Convert.ToDateTime(fecha);
            usuario.Contraseña = "12345678";
            string json = JsonConvert.SerializeObject(usuario);
            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responses = await Http.PostAsync("https://smto-apiv2.azurewebsites.net/api/Usuarios", httpContent);
            respuesta = await responses.Content.ReadFromJsonAsync<Response>();
                if (respuesta.ok)
                {
                if (user == null)
                {
                    navigate.NavigateTo("/");
                }
                await Js.InvokeAsync<object>("Estado", "Éxito", $"El usuario a sido creado con Éxito... Enviamos una contraseña provicional al correo indicado.", "success");
                usuario = new Usuario();

                }
                else
                {
                await Js.InvokeAsync<object>("Estado", "Oops...", $"Ocurrio un error...", "error");
            }
                
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {

            if (firstRender)
            {
                try
                {
                    usuario.IdSucursal = 0;
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

        public class Response
        {
            public bool ok { get; set; }
        }
    }
}

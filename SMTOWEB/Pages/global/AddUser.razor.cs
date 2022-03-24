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
        async Task PostUser()
        {
            if (user == null){usuario.Rol = "4";}
            var fecha = DateTime.Now.ToString("yyyy-MM-ddThh:mm:ss");
            usuario.FechaCreacion = Convert.ToDateTime(fecha);
            usuario.Contraseña = "12345678";
            string json = JsonConvert.SerializeObject(usuario);
            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responses = await Http.PostAsync("https://localhost:44391/api/Usuarios", httpContent);
            respuesta = await responses.Content.ReadFromJsonAsync<Response>();
                if (respuesta.ok)
                {
                  await alerts.AlertSuccess(Js);
                }
                else
                {
                    await Swal.FireAsync("Oops...", "Ocurrio un error al intentar registar los datos", "error");
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

        public class Response
        {
            public bool ok { get; set; }
        }
    }
}

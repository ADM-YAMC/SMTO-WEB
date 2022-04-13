using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using SMTOWEB.Modelo;
using CurrieTechnologies.Razor.SweetAlert2;

namespace SMTOWEB.Pages.Login
{
    public partial class Login
    {
        //[Inject]
        //IJSRuntime JS { get; set; }
      
        public Root respuesta;
        userDataLogin dataLogin = new userDataLogin();
        bool loading = false;
        [Inject]
        SweetAlertService Swal { get; set; }
       private async Task logout()
        {
            try
            {
                loading = true;
                HttpClient Http = new HttpClient();
                string json = JsonConvert.SerializeObject(dataLogin);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var responses = await Http.PostAsync("https://localhost:44391/api/LoginUser", httpContent);
                respuesta = await responses.Content.ReadFromJsonAsync<Root>();
                if (respuesta.ok)
                {

                    await Redirecion(respuesta.user[0].rol);

                }
                else
                {
                    await Swal.FireAsync("Oops...", $"hola mundo", "error");
                    //await JS.InvokeVoidAsync("AlertLoginforms", respuesta.mensaje, "error");
                    loading = false;
                }
            }
            catch (Exception)
            {
                //await Swal.FireAsync("Oops...", $"{respuesta.mensaje}", "error");
                loading = false;
            }
        }
        async Task Redirecion(string rol)
        {

            switch (rol)
            {
                case "1":
                    await JS.InvokeVoidAsync("storage", respuesta.user[0]);
                    NavigationManager.NavigateTo("/administrador");
                    loading = false;
                    break;
                case "2":
                    await JS.InvokeVoidAsync("storage", respuesta.user[0]);
                    NavigationManager.NavigateTo("/administrador");
                    loading = false;
                    break;
                case "3":
                    await JS.InvokeVoidAsync("storage", respuesta.user[0]);
                    NavigationManager.NavigateTo("/smto-kiosco");
                    loading = false;
                    break;
                case "4":
                    await JS.InvokeVoidAsync("storage", respuesta.user[0]);
                    NavigationManager.NavigateTo("/pagina-principal");
                    loading = false;
                    break;
                default:
                    break;
            }
        }
    }
    

    public class userDataLogin
    {
        [Required(ErrorMessage = "Es obligatorio indicar el correo electronico...")]
        public string user { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria...")]
        public string pass { get; set; }
    }

   

    public class Root
    {
        public bool ok { get; set; }
        public string? token { get; set; }
        public string? mensaje { get; set; }
        public List<UserTemp>? user { get; set; }
    }

}

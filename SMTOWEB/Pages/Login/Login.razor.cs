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

namespace SMTOWEB.Pages.Login
{
    public partial class Login
    {
        //[Inject]
        //IJSRuntime JS { get; set; }
      
        public Root respuesta;
        userDataLogin dataLogin = new userDataLogin();
        bool loading = false;
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

                    if (respuesta.user[0].rol == "Usuario")
                    {
                        await JS.InvokeVoidAsync("storage", respuesta.user[0]);
                        NavigationManager.NavigateTo("/pagina-principal");
                        loading = false;
                    }

                }
                else
                {
                    await JS.InvokeVoidAsync("AlertLoginforms", respuesta.mensaje, "error");
                    loading = false;
                }
            }
            catch (Exception)
            {
                await JS.InvokeVoidAsync("errorNotFound");
                loading = false;
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

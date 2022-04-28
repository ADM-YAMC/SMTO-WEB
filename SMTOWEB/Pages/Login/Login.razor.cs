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
        string roles;
        bool loading = false, redireccionar = false;
        UserTemp userTemp;
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
                var responses = await Http.PostAsync("https://smto-apiv2.azurewebsites.net/api/LoginUser", httpContent);
                respuesta = await responses.Content.ReadFromJsonAsync<Root>();
                if (respuesta.ok)
                {
                    if (respuesta.user[0].rol != "4")
                    {
                        Rol();
                        redireccionar = true;
                        loading = false;
                    }
                    else
                    {
                       await RedirigirUsuario();
                    }
                }
                else
                {
                    //await Swal.FireAsync("Oops...", $"hola mundo", "error");
                    await JS.InvokeAsync<object>("AlertLoginforms", respuesta.mensaje, "error");
                    loading = false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                loading = false;
            }
        }

        void Rol()
        {
            if (respuesta.user[0].rol =="1")
            {
                roles = "Administrador";
            }
            else if (respuesta.user[0].rol == "2")
            {
                roles = "Adm Empresa";
            }
            else if (respuesta.user[0].rol == "3")
            {
                roles = "Vendedor";
            }
            else
            {
                roles = "Usuario";
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
                    NavigationManager.NavigateTo("/my-empresa");
                    loading = false;
                    break;
                case "3":
                    await JS.InvokeVoidAsync("storage", respuesta.user[0]);
                    NavigationManager.NavigateTo("smto-kiosco");
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

        async Task RedirigirUsuario()
        {
            userTemp = respuesta.user[0];
            userTemp.rol = "4";
            await JS.InvokeVoidAsync("storage", userTemp);
            NavigationManager.NavigateTo("/pagina-principal");
            loading = false;
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

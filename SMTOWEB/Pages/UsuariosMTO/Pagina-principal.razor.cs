using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Json;
using SMTO_API.Modelos;
using SMTOWEB.Data;
using SMTOWEB.Modelo;
using Newtonsoft.Json;
using Microsoft.JSInterop;
using System.Net.Http;

namespace SMTOWEB.Pages.UsuariosMTO
{
    public partial class Pagina_principal
    {
        Asociar_Tajeta _Tajeta = new();
        private RootTarjeta tarjeta;
        int inputTarjeta;
        private Root carsd;
        GetCardUser getCard = new GetCardUser();
        private TarjetaTemp tarjetas;
        Tarjeta UpdateTarjeta = new Tarjeta();
        private Response response;
        bool loading = false;
        private UserTemp user;
        protected override async Task OnInitializedAsync()
        {

            try
            {
                user = await sessionStorage.GetItemAsync<UserTemp>("usuario");
                if (user != null)
                {
                    carsd = await getCard.Getcard(user.idUsuario);
                    tarjetas = carsd.tarjeta[0];
                }
            }
            catch (Exception)
            {

                Console.WriteLine("");
            }
            
        }
        async Task OnInputCard(ChangeEventArgs args)
        {
            inputTarjeta = args.Value.ToString().Length;
            if (inputTarjeta == 9)
            {
                tarjeta = await http.GetFromJsonAsync<RootTarjeta>($"https://localhost:44391/api/Tarjetas/asociar/{args.Value}");
            }
        }

        async Task OnChangeCard(ChangeEventArgs args)
        {
            tarjetas = carsd.tarjeta.Find(x => x.idTarjeta == Convert.ToInt32(args.Value));
        }

        async Task AddCardForUser()
        {
            if (tarjeta.ok)
            {
                loading = true;
                UpdateTarjeta = new Tarjeta()
                {
                    IdTarjeta = tarjeta.tarjeta[0].IdTarjeta,
                    IdUsuarioCreacion = tarjeta.tarjeta[0].IdUsuarioCreacion,
                    IdUsuarioTitular = user.idUsuario,
                    NumeroTarjeta = tarjeta.tarjeta[0].NumeroTarjeta,
                    Viajes = tarjeta.tarjeta[0].Viajes,
                    Balance = tarjeta.tarjeta[0].Balance,
                    Fecha = tarjeta.tarjeta[0].Fecha,
                    Estado = tarjeta.tarjeta[0].Estado
                };

                string json = JsonConvert.SerializeObject(UpdateTarjeta);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var responses = await http.PutAsync($"https://localhost:44391/api/Tarjetas/{UpdateTarjeta.IdTarjeta}", httpContent);
                response = await responses.Content.ReadFromJsonAsync<Response>();
                if (response.ok)
                {
                    carsd = await getCard.Getcard(user.idUsuario);
                    //tarjetas = (TarjetaTemp)carsd.tarjeta.Reverse<TarjetaTemp>();
                    loading = false;
                }
            }
        }

        //protected override async Task OnAfterRenderAsync(bool firstRender)
        //{
        //    if (firstRender)
        //    {
        //        try
        //        {
        //            var storage = await Js.InvokeAsync<string>("Session");
        //            user = JsonConvert.DeserializeObject<UserTemp>(storage);
        //            StateHasChanged();
        //        }
        //        catch (Exception)
        //        {

        //            Console.WriteLine("Error");
        //        }
        //    }
        //}
    }


 

    public class Asociar_Tajeta
    {
        [Required(ErrorMessage = "Es importante que introduscas el numero de la tarjeta...")]
        public int? numero { get; set; }
    }
    public class Response
    {
        public bool ok { get; set; }
        public string mensaje { get; set; }
    }

}

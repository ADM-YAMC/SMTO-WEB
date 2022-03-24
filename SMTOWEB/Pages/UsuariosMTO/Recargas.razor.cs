using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using SMTO_API.Modelos;
using SMTOWEB.Data;
using SMTOWEB.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMTOWEB.Pages.UsuariosMTO
{
    public partial class Recargas
    {
        Asociar_Tajeta _Tajeta = new();
        private RootTarjeta tarjeta;
        int inputTarjeta;
        private Root carsd;
        GetCardUser getCard = new GetCardUser();
        UserTemp user = new UserTemp();
        private TarjetaTemp tarjetas;
        Tarjeta UpdateTarjeta = new Tarjeta();
        private Response response;
        bool loading = false;
        protected override async Task OnInitializedAsync()
        {

            

        }
        void OnChangeCard(ChangeEventArgs args)
        {
            tarjetas = carsd.tarjeta.Find(x => x.idTarjeta == Convert.ToInt32(args.Value));
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
                    carsd = await getCard.Getcard(user.idUsuario);
                    tarjetas = carsd.tarjeta[0];
                }
                catch (Exception)
                {

                    Console.WriteLine("Error");
                }
            }
        }
    }
}

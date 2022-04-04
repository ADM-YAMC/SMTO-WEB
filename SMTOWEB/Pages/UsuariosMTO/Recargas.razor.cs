using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using SMTO_API.Modelos;
using SMTOWEB.Data;
using SMTOWEB.Modelo;
using SMTOWEB.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SMTOWEB.Pages.UsuariosMTO
{
    public partial class Recargas
    {
        Asociar_Tajeta _Tajeta = new();
       
        private Root carsd;
        GetCardUser getCard = new GetCardUser();
        UserTemp user = new UserTemp();
        private TarjetaTemp tarjetas;
        Tarjeta UpdateTarjeta = new Tarjeta();
        private ResponseAddRecargas response;
        bool loading = false, confirmacion = false,TipoMensaje;
        CallAlerts alerts = new CallAlerts();
        int value = 1;
        Modelo.RecargasTemp recargas = new Modelo.RecargasTemp();
        MetodoPago metodoPago = new MetodoPago();
        string digitos_finales = "", msj;
        bool resultado = true, forms = true;
        Procesar_recargas Procesar_Recargas = new Procesar_recargas();
        

        private bool ShowModal = false;

        private void ToggleModal()
        {
            ShowModal = !ShowModal;
            HandleModalState();
        }
        private bool _fadeInModal;
        private bool _modalRendered;
        protected override void OnParametersSet()
        {
            HandleModalState();
        }
        public async void HandleModalState()
        {
            if (ShowModal)
            {
                _modalRendered = true;
                await Task.Delay(10);
                _fadeInModal = true;
            }
            else
            {
                _modalRendered = false;
                await Task.Delay(400);
                _fadeInModal = false;
            }
            StateHasChanged();
        }
        async Task Metodo_pago()
        {
            var result = new string(metodoPago.Numero_tarjeta_pago.Reverse().Take(4).Reverse().ToArray());
            digitos_finales = result;

            resultado = await Js.InvokeAsync<bool>("fValidarTarjeta", metodoPago.Numero_tarjeta_pago);
            Console.WriteLine(resultado);
            ToggleModal();

        }

        async Task SelectedCarsChanged(ChangeEventArgs e)
        {
            Console.WriteLine(e.Value);

            if (e.Value.ToString().Length >= 16)
            {
                resultado = await Js.InvokeAsync<bool>("fValidarTarjeta", e.Value);
                if (!resultado)
                {
                    msj = "El numero de la tarjeta es invalido...";
                }
            }
            else
            {
                msj = "";
            }
        }

        async Task SomeMethod()
        {
            await Js.InvokeVoidAsync("DismmissModal", "#staticBackdrop");
        }
        protected override async Task OnInitializedAsync()
        {

            

        }

        async Task Procesar_pago()
        {
            loading = true;
             var tarjeta = carsd.tarjeta.Find(x =>x.numeroTarjeta == recargas.numeroTarjeta);
          
             response = await Procesar_Recargas.Procesar_pago_recarga_adactador(recargas, tarjeta, value, user);
            
            if (response.ok)
            {
                confirmacion = true;
                TipoMensaje = response.ok;
                loading = false;
            }
            else
            {
                TipoMensaje = response.ok;
            }
        }

        void OnChangeCard(ChangeEventArgs args)
        {
            recargas.numeroTarjeta = Convert.ToInt32(args.Value);
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
                    StateHasChanged();
                    tarjetas = carsd.tarjeta[0];
                    
                }
                catch (Exception)
                {

                    Console.WriteLine("Error");
                }
            }
        }

        void CloseModal()
        {
            ToggleModal();
            metodoPago = new MetodoPago();
            msj = "";
            digitos_finales = "";
        }

        void VolverAIntentar()
        {
            confirmacion = false;
            forms = false;
        }
    }
    

   
}

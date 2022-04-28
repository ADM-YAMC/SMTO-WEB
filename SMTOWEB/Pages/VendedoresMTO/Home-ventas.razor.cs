
using Microsoft.JSInterop;
using Net.ConnectCode.BarcodeFontsStandard2D;
using Newtonsoft.Json;
using SMTO_API.Modelos;
using SMTOWEB.Modelo;
using SMTOWEB.Modelos;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace SMTOWEB.Pages.VendedoresMTO
{
    public partial class Home_ventas
    {
        //https://localhost:44391
        Modelo.RecargasTemp recargas = new Modelo.RecargasTemp();
        UserTemp user = new UserTemp();
        private ResponseAddRecargas response;
        private ResponseCardForNumber responseCardFor;
        private PGetInfoSucursal pGetInfoSucursal;
        HttpClient Http = new HttpClient();
        Procesar_recargas Procesar_Recargas = new Procesar_recargas();
        TotalVentaDia totalVenta;
        public bool VF { get; set; }
        Timer _tm = null;
        AutoResetEvent _autoEvent = null;
        int conunt = 0;
        CustomUsuarios usuarioTitular;
        Usuario usuario;
        dynamic f;
        string QRCodeSTR = "https://upload.wikimedia.org/wikipedia/commons/d/d7/Commons_QR_code.png", qrCodeStr;
        protected override async Task OnInitializedAsync()
        {

            try
            {
                user = await sessionStorage.GetItemAsync<UserTemp>("usuario");
                if (user != null)
                {
                    await pGetdataSucursal();
                    await GetTotalVendidoDia();
                }
                
            }
            catch (Exception)
            {

                totalVenta = new TotalVentaDia();
            }
           
        }


        async Task GetCardInfo(string args)
        {
            if (args.Length == 9)
            {
                responseCardFor = await Http.GetFromJsonAsync<ResponseCardForNumber>($"https://smto-apiv2.azurewebsites.net/api/Tarjetas/tarjeta/{args}");
                if (responseCardFor.ok)
                {
                    if (responseCardFor?.tarjeta?.idUsuarioTitular != 0)
                    {
                        usuario = await Http.GetFromJsonAsync<Usuario>($"https://smto-apiv2.azurewebsites.net/api/Usuarios/{responseCardFor.tarjeta.idUsuarioTitular}");
                      
                    }
                    
                }
                //QR(responseCardFor.tarjeta.numeroTarjeta.ToString());
            }
            else
            {
                responseCardFor = null;
            }

        }

        async Task QR()
        {
        }

        async Task GetTotalVendidoDia()
        {
            var fecha = DateTime.Now.ToString("yyyy-MM-dd");
            totalVenta = await Http.GetFromJsonAsync<TotalVentaDia>
                      ($"https://smto-apiv2.azurewebsites.net/api/Sucursal/info/totalVendido/{user.idSucursal}/{fecha}");
        }

        public void StartTimer()
        {
            _autoEvent = new AutoResetEvent(false);
            _tm = new Timer(Execute, _autoEvent, 1000, 1000);
        }
        public void Execute(Object stateInfo)
        {
            
            if (conunt == 5)
            {
                VF = false;
                response = null;
                StateHasChanged();
                return;
            }
            conunt++;

        }

        async Task Procesar_pago()
        {
            conunt = 0;
            if (responseCardFor.ok && (int)recargas.BalanceViaje < pGetInfoSucursal.Balance || ((int)recargas.BalanceViaje * 20) < pGetInfoSucursal.Balance)
            {
                VF = false;
            response = await Procesar_Recargas.Procesar_pago_recarga(recargas, responseCardFor, value, user);
            if (response.ok)
            {
                await pGetdataSucursal();
                await GetTotalVendidoDia();
                await Limpiar();
            }
            }
            else
            {
                VF = true;
                StartTimer();
            }
            
        }

        async Task Bloqueo(PGetInfoSucursal sucursal)
        {
            string msj = "Esta sucursal a sido bloqueada por las personas que " +
                "administran la misma. Lamentamos los inconvenientes... Para mas " +
                "informacion, pongase en contacto con su cental...";
            if (!sucursal.Estado)
            {
                await Js.InvokeAsync<object>
                    ("Estado", "Oops..", $"{msj}", "info");
                navigate.NavigateTo("/");
                await sessionStorage.RemoveItemAsync("usuario");

            }
        }
        async Task Limpiar()
        {
            StartTimer();
            recargas = new RecargasTemp();
            value = 1;
            responseCardFor = null;
        }

        async Task pGetdataSucursal()
        {
            pGetInfoSucursal = await Http.GetFromJsonAsync<PGetInfoSucursal>
                       ($"https://smto-apiv2.azurewebsites.net/api/Sucursal/info/sucursal/{Convert.ToInt32(user.idSucursal)}");

            await Bloqueo(pGetInfoSucursal);
            
        }
    }
    public class TotalVentaDia
    {
        public int total { get; set; }
        public DateTime fecha { get; set; }
    }
}

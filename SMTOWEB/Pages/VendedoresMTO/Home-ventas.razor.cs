using Microsoft.JSInterop;
using Newtonsoft.Json;
using QRCoder;
using SMTO_API.Modelos;
using SMTOWEB.Modelo;
using SMTOWEB.Modelos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace SMTOWEB.Pages.VendedoresMTO
{
    public partial class Home_ventas
    {

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
        string QRCodeSTR;
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
                responseCardFor = await Http.GetFromJsonAsync<ResponseCardForNumber>($"https://localhost:44391/api/Tarjetas/tarjeta/{args}");
                if (responseCardFor.ok)
                {
                    if (responseCardFor?.tarjeta?.idUsuarioTitular != 0)
                    {
                        usuarioTitular = await Http.GetFromJsonAsync<CustomUsuarios>($"https://localhost:44391/api/Usuarios/{responseCardFor.tarjeta.idUsuarioTitular}");
                      
                    }
                    
                }
                QR(responseCardFor.tarjeta.numeroTarjeta.ToString());
            }
            else
            {
                responseCardFor = null;
            }

        }

        void QR(string numeroT)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(numeroT, QRCodeGenerator.ECCLevel.Q);
                QRCode qRCode = new QRCode(qRCodeData);
                using (Bitmap oBit = qRCode.GetGraphic(20))
                {
                    oBit.Save(ms, ImageFormat.Png);
                    QRCodeSTR = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        async Task GetTotalVendidoDia()
        {
            var fecha = DateTime.Now.ToString("yyyy-MM-dd");
            totalVenta = await Http.GetFromJsonAsync<TotalVentaDia>
                      ($"https://localhost:44391/api/Sucursal/info/totalVendido/{user.idSucursal}/{fecha}");
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

        //protected override async Task OnAfterRenderAsync(bool firstRender)
        //{
        //    HttpClient Http = new HttpClient();
        //    if (firstRender)
        //    {
        //        try
        //        {
        //            var storage = await Js.InvokeAsync<string>("Session");
        //            user = JsonConvert.DeserializeObject<UserTemp>(storage);
        //           await pGetdataSucursal();
        //            StateHasChanged();

        //        }
        //        catch (Exception)
        //        {

        //            Console.WriteLine("Error");
        //        }
        //    }
        //}
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
                       ($"https://localhost:44391/api/Sucursal/info/sucursal/{Convert.ToInt32(user.idSucursal)}");
            
        }
    }
    public class TotalVentaDia
    {
        public int total { get; set; }
        public DateTime fecha { get; set; }
    }
}

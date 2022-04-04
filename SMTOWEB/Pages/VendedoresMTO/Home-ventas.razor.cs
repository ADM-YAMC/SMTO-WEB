using Microsoft.JSInterop;
using Newtonsoft.Json;
using SMTO_API.Modelos;
using SMTOWEB.Modelo;
using SMTOWEB.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
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
        protected override async Task OnInitializedAsync()
        {

           

        }
        async Task GetCardInfo(Microsoft.AspNetCore.Components.ChangeEventArgs args)
        {
            if (args.Value.ToString().Length == 9)
            {
                responseCardFor = await Http.GetFromJsonAsync<ResponseCardForNumber>($"https://localhost:44391/api/Tarjetas/tarjeta/{args.Value}");
            }
            else
            {
                responseCardFor = null;
            }

        }


        async Task Procesar_pago()
        {
            response = await Procesar_Recargas.Procesar_pago_recarga(recargas,responseCardFor,value,user);
            if (response.ok)
            {
               await pGetdataSucursal();
            }
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            HttpClient Http = new HttpClient();
            if (firstRender)
            {
                try
                {
                    var storage = await Js.InvokeAsync<string>("Session");
                    user = JsonConvert.DeserializeObject<UserTemp>(storage);
                   await pGetdataSucursal();
                    StateHasChanged();

                }
                catch (Exception)
                {

                    Console.WriteLine("Error");
                }
            }
        }

        async Task pGetdataSucursal()
        {
            pGetInfoSucursal = await Http.GetFromJsonAsync<PGetInfoSucursal>
                       ($"https://localhost:44391/api/Sucursal/info/sucursal/{Convert.ToInt32(user.idSucursal)}");
        }
    }
  
}

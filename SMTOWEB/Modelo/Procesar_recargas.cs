using Newtonsoft.Json;
using SMTO_API.Modelos;
using SMTOWEB.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SMTOWEB.Modelo
{
    public class Procesar_recargas
    {
        private ResponseAddRecargas response;
       public async Task<ResponseAddRecargas> Procesar_pago_recarga
            (RecargasTemp recargas, ResponseCardForNumber responseCardFor, int tipoRecarga, UserTemp user)
        {
            int balance = 0, viajes = 0, totalVendido = 0;

            if (responseCardFor.tarjeta != null)
            {
                if (tipoRecarga != 1)
                {
                    balance = (int)recargas.BalanceViaje;
                    viajes = 0;
                    totalVendido = balance;
                }
                else
                {
                    balance = 0;
                    viajes = (int)recargas.BalanceViaje;
                    totalVendido = viajes * 20;
                }
                var rescarga = new Modelo.RecargasCard()
                {
                    IdTarjeta = responseCardFor.tarjeta.idTarjeta,
                    IdUsuario = user.idUsuario,
                    Balance = balance,
                    Viajes = viajes,
                    IdSucrursal = Convert.ToInt32(user.idSucursal),
                    TotalVendido = totalVendido
                };
                HttpClient Http = new HttpClient();
                string json = JsonConvert.SerializeObject(rescarga);
                StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                var responses = await Http.PostAsync("https://smto-apiv2.azurewebsites.net/api/Recargas", httpContent);
                response = await responses.Content.ReadFromJsonAsync<ResponseAddRecargas>();
                return response;
            }
            else
            {
                return null;
            }
        }

        public async Task<ResponseAddRecargas> Procesar_pago_recarga_adactador
           (RecargasTemp recargas, TarjetaTemp Tarjeta, int tipoRecarga, UserTemp user)
        {
            var responseCardFor = new ResponseCardForNumber()
            {
                ok = true,
                tarjeta = Tarjeta
            };
            return await Procesar_pago_recarga(recargas,responseCardFor, tipoRecarga,user);

        }

    }
}

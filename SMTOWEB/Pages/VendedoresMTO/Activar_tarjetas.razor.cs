﻿using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using SMTO_API.Modelos;
using SMTOWEB.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SMTOWEB.Pages.VendedoresMTO
{
    public partial class Activar_tarjetas
    {
        RootTarjeta response;
        Tarjeta tarjeta = new Tarjeta();
        TActivar activar = new TActivar();
        [Parameter]
        public int idUser { get; set; }
        public string Ntarjeta { get; set; }
        async Task GuardarTarjeta()
        {
            tarjeta = new Tarjeta()
            {
                NumeroTarjeta = Convert.ToInt32(activar.NTarjeta),
                Balance = 0,
                Viajes = 0,
                Estado = true,
                IdUsuarioTitular = 0,
                IdUsuarioCreacion = idUser

            };
            string json = JsonConvert.SerializeObject(tarjeta);
            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var responses = await Http.PostAsync("https://localhost:44391/api/Tarjetas", httpContent);
            response = await responses.Content.ReadFromJsonAsync<RootTarjeta>();
        }
    }

    public class TActivar{
        [Required(ErrorMessage = "Inserte o escanee el numero de la tarjeta...")]
        public string NTarjeta { get; set; }
    }
}

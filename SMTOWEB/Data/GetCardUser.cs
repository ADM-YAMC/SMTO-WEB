using SMTO_API.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SMTOWEB.Data
{
    public class GetCardUser
    {
        public async Task<Root> Getcard(int id)
        {
            HttpClient http = new HttpClient();
            var tarjetas = await http.GetFromJsonAsync<Root>($"https://localhost:44391/api/Tarjetas/usuario/{id}");
            return tarjetas;
        }
    }
}

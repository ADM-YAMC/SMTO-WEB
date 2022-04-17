using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using SMTO_API.Modelos;
using SMTOWEB.Modelo;
namespace SMTOWEB.Servicios
{
    public class GetUsuariosServices 
    {
        public async Task<List<Usuario>> GetUsuarios()
        {
            HttpClient http = new HttpClient();
            var usuarios = await http.GetFromJsonAsync<Root>("https://localhost:44391/api/Usuarios");
            return usuarios.usuarios;
        }

        public class Root
        {
            public bool ok { get; set; }
            public string mensaje { get; set; }
            public List<Usuario> usuarios { get; set; }
        }
    }
}

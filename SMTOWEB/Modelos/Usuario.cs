using System;
using System.Collections.Generic;

#nullable disable

namespace SMTO_API.Modelos
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public int? IdSucursal { get; set; }
        public string NombreApellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }
        public DateTime LoginDate { get; set; }
        public string Token { get; set; }
        public DateTime FechaCreacion { get; set; }
    }

    public partial class UsuarioTemp
    {
        public int IdUsuario { get; set; }
        public int? IdSucursal { get; set; }
        public string NombreApellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string NombreUsuario { get; set; }
        public string Rol { get; set; }
    }

   public class CustomUsuarios
    {
        public bool Ok { get; set; }
        public string Mensaje { get; set; }
        public List<Usuario>? Usuarios { get; set; }
    }
}

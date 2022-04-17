using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SMTO_API.Modelos
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        [Required(ErrorMessage ="Este campo es requerido...")]
        public int? IdSucursal { get; set; }
        public int? IdEmpresa { get; set; }
        [Required(ErrorMessage = "Este campo es requerido...")]
        public string NombreApellido { get; set; }
        [Required(ErrorMessage = "Este campo es requerido...")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "Este campo es requerido...")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Este campo es requerido...")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Este campo es requerido...")]
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        [Required(ErrorMessage = "Este campo es requerido...")]
        public string Rol { get; set; }
        public DateTime LoginDate { get; set; }
        public string Token { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool? Estado { get; set; }
    }


    public partial class UsuarioTemp
    {
        public int IdUsuario { get; set; }
        public int? IdSucursal { get; set; }
        public int? IdEmpresa { get; set; }
        public string NombreApellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string NombreUsuario { get; set; }
        public string Rol { get; set; }
        public bool? Estado { get; set; }
    }

   public class CustomUsuarios
    {
        public bool Ok { get; set; }
        public string Mensaje { get; set; }
        public List<Usuario>? Usuarios { get; set; }
    }
}

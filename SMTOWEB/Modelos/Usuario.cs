using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SMTO_API.Modelos
{
    public partial class Usuario
    {

        public int IdUsuario { get; set; }
        public int? IdSucursal { get; set; }
       [Required(ErrorMessage = "Este campo es obligatorio...")]
        public string NombreApellido { get; set; }
        public string Cedula { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio...")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio...")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio...")]
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio...")]
        public string Rol { get; set; }
        public string LoginDate { get; set; }
        public string Token { get; set; }
        public string FechaCreacion { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SMTO_API.Modelos
{
    public partial class Sucursal
    {
        public int IdSucursal { get; set; }
        public int IdEmpresa { get; set; }
        public int IdUsuario { get; set; }
        [Required(ErrorMessage = "Este campo es requerido...")]
        public string NombreSucursal { get; set; }
        [Required(ErrorMessage = "Este campo es requerido...")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Este campo es requerido...")]
        public string Telefono { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }
    }
}

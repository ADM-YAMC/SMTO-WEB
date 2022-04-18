using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SMTO_API.Modelos
{
    public partial class Empresa
    {
        public int IdEmpresa { get; set; }
        [Required(ErrorMessage = "Este campo es requerido...")]
        public int IdUsuario { get; set; }
        [Required(ErrorMessage ="Este campo es requerido...")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Este campo es requerido...")]
        public string RNC { get; set; }
        [Required(ErrorMessage = "Este campo es requerido...")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Este campo es requerido...")]
        public string Direccion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }
    }
    public partial class GetEmpresa
    {
        public int IdEmpresa { get; set; }
        public int IdUsuario { get; set; }
        public string Nombre_propietario { get; set; }
        public string RNC { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool? Estado { get; set; }
    }
}

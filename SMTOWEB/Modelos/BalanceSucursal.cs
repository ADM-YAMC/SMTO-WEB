using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SMTO_API.Modelos
{
    public partial class BalanceSucursal
    {
        public int IdBalanceSucursal { get; set; }
        public int IdSucursal { get; set; }
        public int IdEmpresa { get; set; }
        public int? IdUsuario { get; set; }
        [Required(ErrorMessage ="Este campo es requerido...")]
        public int? Balance { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}

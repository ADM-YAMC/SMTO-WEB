using System;
using System.Collections.Generic;

#nullable disable

namespace SMTO_API.Modelos
{
    public partial class BalanceSucursal
    {
        public int IdBalanceSucursal { get; set; }
        public int IdSucursal { get; set; }
        public int? IdUsuario { get; set; }
        public string Balance { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}

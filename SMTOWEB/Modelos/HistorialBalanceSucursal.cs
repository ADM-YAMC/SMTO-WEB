using System;
using System.Collections.Generic;

#nullable disable

namespace SMTO_API.Modelos
{
    public partial class HistorialBalanceSucursal
    {
        public int IdHistorialBalanceSucrursal { get; set; }
        public int IdUsuario { get; set; }
        public int IdEmpresa { get; set; }
        public int IdBalanceSucursal { get; set; }
        public string BalanceActula { get; set; }
        public string NuevoBalace { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}

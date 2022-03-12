using System;
using System.Collections.Generic;

#nullable disable

namespace SMTO_API.Modelos
{
    public partial class HistorialRecarga
    {
        public int IdRecarga { get; set; }
        public int IdTarjeta { get; set; }
        public int IdUsuario { get; set; }
        public int? IdSucrursal { get; set; }
        public int Balance { get; set; }
        public int Viajes { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}

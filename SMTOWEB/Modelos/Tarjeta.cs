using System;
using System.Collections.Generic;

#nullable disable

namespace SMTO_API.Modelos
{
    public partial class Tarjeta
    {
        public int IdTarjeta { get; set; }
        public int? IdUsuarioTitular { get; set; }
        public int NumeroTarjeta { get; set; }
        public int IdUsuarioCreacion { get; set; }
        public int Viajes { get; set; }
        public int Balance { get; set; }
        public DateTime Fecha { get; set; }
        public bool? Estado { get; set; }
    }
}

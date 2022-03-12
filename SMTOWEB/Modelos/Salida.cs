using System;
using System.Collections.Generic;

#nullable disable

namespace SMTO_API.Modelos
{
    public partial class Salida
    {
        public int IdSalida { get; set; }
        public int IdTarjeta { get; set; }
        public string EstacionSalida { get; set; }
        public string TipoTrasporte { get; set; }
        public DateTime Fecha { get; set; }
    }
}

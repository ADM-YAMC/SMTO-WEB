using System;
using System.Collections.Generic;

#nullable disable

namespace SMTO_API.Modelos
{
    public partial class Entradum
    {
        public int IdEntrada { get; set; }
        public int IdTarjeta { get; set; }
        public string EstacionEntrada { get; set; }
        public string TipoTrasporte { get; set; }
        public DateTime Fecha { get; set; }
    }
}

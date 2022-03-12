using System;
using System.Collections.Generic;

#nullable disable

namespace SMTO_API.Modelos
{
    public partial class Sucursal
    {
        public int IdSucursal { get; set; }
        public int IdEmpresa { get; set; }
        public int IdUsuario { get; set; }
        public string NombreSucursal { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}

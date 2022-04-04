using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMTOWEB.Modelos
{
    public class PGetInfoSucursal
    {
        public int Balance { get; set; }
        public DateTime Fecha_Actualizacion { get; set; }
        public int IdEmpresa { get; set; }
        public int IdBalanceSucursal { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public string Nombre_Sucursal { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}

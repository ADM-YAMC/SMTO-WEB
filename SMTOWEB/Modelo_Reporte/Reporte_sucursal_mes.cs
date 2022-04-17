using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMTOWEB.Modelo_Reporte
{
    public class Reporte_sucursal_mes
    {
        public int IdTarjeta { get; set; }
        public int IdSucursal { get; set; }
        public int Numero_Tarjeta { get; set; }
        public int Balance { get; set; }
        public int Viajes { get; set; }
        public int TotalVendido { get; set; }
        public DateTime Fecha_Creacion { get; set; }
    }
}

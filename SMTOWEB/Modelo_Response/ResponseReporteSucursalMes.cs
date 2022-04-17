using SMTOWEB.Modelo_Reporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMTOWEB.Modelo_Response
{
    public class ResponseReporteSucursalMes
    {
        public bool ok { get; set; }
        public List<Reporte_sucursal_mes>? reporte { get; set; }
    }
}

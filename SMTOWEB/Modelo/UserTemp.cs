using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMTOWEB.Modelo
{
    public class UserTemp
    {
       
            public int idUsuario { get; set; }
            public int? idSucursal { get; set; }
            public string nombreApellido { get; set; }
            public string cedula { get; set; }
            public string telefono { get; set; }
            public string direccion { get; set; }
            public string nombreUsuario { get; set; }
            public string rol { get; set; }
            public string? loginDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace SMTOWEB.Modelo
{
    public class Recargas
    {

        public int IdRecarga { get; set; }
        public int IdTarjeta { get; set; }
        public int IdUsuario { get; set; }
        [Required(ErrorMessage = "El monto del balance es requerido...")]
        public int? Balance { get; set; }
        [Required(ErrorMessage = "La cantidad de viajes es requerida...")]
        public int? Viajes { get; set; }
        public DateTime Fecha { get; set; }
    }
}

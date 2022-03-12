using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace SMTOWEB.Modelo
{
    public class MetodoPago
    {
        [Required(ErrorMessage = "El numero de la tarjeta  es requerido...")]
        public string Numero_tarjeta_pago { get; set; }
        [Required]
        public string Mes { get; set; }
        [Required]
        public int? Año { get; set; }
        [Required]
        public int? CVV { get; set; }
    }
}

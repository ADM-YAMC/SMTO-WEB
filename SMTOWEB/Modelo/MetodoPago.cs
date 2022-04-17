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
        [MaxLength(19,ErrorMessage ="El numero de la tarjeta es muy largo...")]
        [MinLength(19,ErrorMessage ="El numero de tarjeta es muy corto...")]
        public string Numero_tarjeta_pago { get; set; }
        [Required]
        public string Mes { get; set; }
        [Required]
        [Range(22, 35)]
        public int? Año { get; set; }
        [Required]
        [Range(100,999)]
        public int? CVV { get; set; }
    }
}

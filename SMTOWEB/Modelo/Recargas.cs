using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace SMTOWEB.Modelo
{
    public class RecargasCard
    {
        public int IdRecarga { get; set; }
        public int IdTarjeta { get; set; }
        public int IdUsuario { get; set; }
        public int? IdSucrursal { get; set; }
        public int? Balance { get; set; }
        public int? Viajes { get; set; }
        public int TotalVendido { get; set; }
        public DateTime Fecha { get; set; }
    }

    public class RecargasTemp
    {

        public int IdRecarga { get; set; }
        public int IdTarjeta { get; set; } = 0;
        public int IdUsuario { get; set; }
        [Required(ErrorMessage = "Desbes de introducir el monto o la cantidad de viajes....")]
        public int? BalanceViaje { get; set; }
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Debes de selecionar una de tus tarjetas...")]
        public int? numeroTarjeta { get; set; }
    }


}

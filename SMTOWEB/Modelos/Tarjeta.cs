using System;
using System.Collections.Generic;

#nullable disable

namespace SMTO_API.Modelos
{
    public class RootTarjeta
    {
        public bool ok { get; set; }
        public string? mensaje { get; set; }
        public List<Tarjeta> tarjeta { get; set; }
    }
    public partial class Tarjeta
    {
        public int IdTarjeta { get; set; }
        public int? IdUsuarioTitular { get; set; }
        public int NumeroTarjeta { get; set; }
        public int IdUsuarioCreacion { get; set; }
        public int Viajes { get; set; }
        public int Balance { get; set; }
        public DateTime? Fecha { get; set; }
        public bool? Estado { get; set; }
    }

    public class TarjetaTemp
    {
        public int idTarjeta { get; set; }
        public int idUsuarioTitular { get; set; }
        public int numeroTarjeta { get; set; }
        public int idUsuarioCreacion { get; set; }
        public int viajes { get; set; }
        public int balance { get; set; }
        public DateTime fecha { get; set; }
        public bool estado { get; set; }
        //public List<Entradum> entradas { get; set; }
        //public List<Salida> salidas { get; set; }
        //public List<HistorialRecarga> historialRecargas { get; set; }
    }

    public class Root
    {
        public bool ok { get; set; }
        public List<TarjetaTemp> tarjeta { get; set; }
    }
}

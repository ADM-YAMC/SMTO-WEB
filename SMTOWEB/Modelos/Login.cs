using System;
using System.Collections.Generic;

#nullable disable

namespace SMTO_API.Modelos
{
    public partial class Login
    {
        public int IdLogin { get; set; }
        public int IdUsuario { get; set; }
        public DateTime? LoginDate { get; set; }
        public string Token { get; set; }
    }
}

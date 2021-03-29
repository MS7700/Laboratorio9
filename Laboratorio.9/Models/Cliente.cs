using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio._9.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public Decimal Monto { get; set; }
    }
}
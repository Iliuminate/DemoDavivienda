using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DaviviendaDEMO.Models
{
    public class Entidad_Pago
    {
        [Key]
        public string id { get; set; }

        public string Empresa { get; set; }

        public double Monto { get; set; }
        
        public int  id_usuario { get; set; }

        [Required]
        public bool estado { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;

namespace Cylecar.Models
{
    public class ChargePoint
    {
        public string Descripcion { get; set; }
        public string Edificio { get; set; }
        public string CodigoPostal { get; set; }
        public string Calle { get; set; }
        public string Localidad { get; set; }
        public Position Localizacion { get; set; }
        public string Enlace { get; set; }
    }
}

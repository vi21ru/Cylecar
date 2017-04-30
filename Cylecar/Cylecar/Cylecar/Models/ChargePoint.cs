using Java.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylecar.Models
{
    public class ChargePoint
    {
        public int IdPunto { get; set; }
        public int MennekesType { get; set; }
        public int SchukoType { get; set; }
        public string PointDesc { get; set; }
        public bool PublicPoint { get; set; }
        public string Place { get; set; }
        public string Adress { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        //public Geopoint Location { get; set; }
        public Date LastUpdate { get; set; }
        public Uri Link { get; set; }
    }
}

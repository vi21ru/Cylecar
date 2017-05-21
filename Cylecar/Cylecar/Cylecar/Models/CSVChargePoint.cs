using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylecar.Models
{
    class CSVChargePoint
    {
        //Nombre del Organismo	Descripción	DatosPersonales	Dirección	Calle	CodigoPostal	Localidad	Localidad	SoloClasificar	Teléfono	Telefax oficial	Fax	e-mail	Páginas de internet	Posicion	Información adicional	Directorio Superior	Identificador Directorio Superior	Identificador	ultimaActualizacion	Enlace al contenido
        public string NombreDelOrganismo { get; set; }
        public string Descripcion { get; set; }
        public string DatosPersonales { get; set; }
        public string Direccion { get; set; }
        public string Calle { get; set; }
        public string CodigoPostal { get; set; }
        public string Localidad { get; set; }
        public string Localidad2 { get; set; }
        public string SoloClasificar { get; set; }
        public string Telefono { get; set; }
        public string TelefaxOficial { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Posicion { get; set; }
        public string InfoAdicional { get; set; }
        public string DirectorioSuperior { get; set; }
        public string IdentificadorDirectorio { get; set; }
        public string Identificacor { get; set; }
        public string UltimaActualiacion { get; set; }
        public string EnlaceContenido { get; set; }

    }
}

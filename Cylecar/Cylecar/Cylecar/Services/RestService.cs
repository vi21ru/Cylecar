using CsvHelper;
using Cylecar.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Cylecar.Services
{
    class RestService
    {

        //public List<ChargePoint> Items { get; private set; }

        /* public async Task<List<ChargePoint>> RefreshDataAsync()
         {
             HttpClient httpClient = new HttpClient();
             httpClient.DefaultRequestHeaders.Accept.TryParseAdd("application/json");
             //http://www.datosabiertos.jcyl.es/web/jcyl/risp/es/energia/vehiculo_electrico/1284273412751.json

             Items = new List<ChargePoint>();
             // uri = http://www.datosabiertos.jcyl.es/web/jcyl/risp/es/energia/vehiculo_electrico/1284273412751.json

             var uri = new Uri("http://www.datosabiertos.jcyl.es/web/jcyl/risp/es/energia/vehiculo_electrico/1284273412751.json");

             try
             {
                 var response = await httpClient.GetAsync(uri);
                 if (response.IsSuccessStatusCode)
                 {
                     var content = await response.Content.ReadAsStringAsync();
                     Items = JsonConvert.DeserializeObject<List<ChargePoint>>(content);
                 }
             }
             catch (Exception ex)
             {
                 Debug.WriteLine(@"				ERROR {0}", ex.Message);
             }

             return Items;
         }*/
         public async void getData(){
            try
            {
                HttpClient clienteHttp = new HttpClient();
                clienteHttp.DefaultRequestHeaders.Accept.TryParseAdd("application/json");

                var uri = new Uri("http://www.datosabiertos.jcyl.es/web/jcyl/risp/es/energia/vehiculo_electrico/1284273412751.csv");
                var request = (HttpWebRequest)WebRequest.Create(uri);
                WebResponse responseObject = await Task<WebResponse>.Factory.FromAsync(request.BeginGetResponse, request.EndGetResponse, request);
                var responseStream = responseObject.GetResponseStream();
                var myReader = new StreamReader(responseStream);
                var reader = new CsvReader(myReader);
                //CSVReader will now read the whole file into an enumerable
                //IEnumerable<CSVChargePoint> records = reader.GetRecords<CSVChargePoint>();
                /*foreach (CSVChargePoint record in records.Take(5))
                {
                    Debug.WriteLine("{0} {1}, {2}, {3}", record.NombreDelOrganismo, record.Posicion, record.CodigoPostal,
                        record.Localidad);
                }*/

            }
            catch (Exception ex)
            {
                Debug.WriteLine("error: " + ex.Message);
            }
        }
    }
}

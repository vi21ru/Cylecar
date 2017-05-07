using Cylecar.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylecar.Services
{
    class RestService
    {

        public List<ChargePoint> Items { get; private set; }

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
    }
}

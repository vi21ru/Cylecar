
using Cylecar.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using Xamarin.Forms;

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
        public async void getData(List<ChargePoint> lista)
        {
            try { 
            /*HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.TryParseAdd("application/json");
            var uri = new Uri("http://www.datosabiertos.jcyl.es/web/jcyl/risp/es/energia/vehiculo_electrico/1284273412751.json");
            //var uri = new Uri("http://www.datosabiertos.jcyl.es/web/jcyl/risp/es/energia/vehiculo_electrico/1284273412751.json");
            var respuestaJson = httpClient.GetStringAsync(uri).Result;
            JObject parser = JObject.Parse(respuestaJson);*/
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.TryParseAdd("application/csv");
            Uri uri = new Uri("http://www.datosabiertos.jcyl.es/web/jcyl/risp/es/energia/vehiculo_electrico/1284273412751.csv");
                var s = httpClient.GetStringAsync(uri).Result; //obtengo string con datos
                //Debug.WriteLine("var s: " + s.GetType() + " - " + s.ToString());
                s = Regex.Replace(s, "\n\"", "&");
                s = Regex.Replace(s, "\"", "");
                //char caracter = '\\';
                //li = s.Replace("\""+caracter +"\"", "");
                var lineas = Regex.Split(s, "&");
                var num = lineas.Length;
                var stringLista = new List<string>();

                foreach (string st in lineas)
                {
                    stringLista.Add(st);
                }
                var sListaDef = stringLista.Skip(1);
                var nums = stringLista.Count;
                //var columnas = lineas[1].Split(';');
                //var colNames = columnas.Length;

                foreach (string l in sListaDef)
                {

                    var res = Regex.Split(l, ";");
                    
                    ChargePoint cp = new ChargePoint();
                    cp.Descripcion = res[0];
                    if (res[0].Contains("privado") | res[0].Contains("exclusivo"))
                    {
                        cp.Privado = "Red";
                    }
                    else
                        cp.Privado = "Green";
                    cp.Edificio = res[2];
                    cp.Calle = res[4];
                    cp.CodigoPostal = res[5];
                    cp.Localidad = res[6];
                    var sPosition = res[14].Split('#');

                    cp.Localizacion = new Xamarin.Forms.Maps.Position(Double.Parse(sPosition[0]), double.Parse(sPosition[1]));
                    string link = res[20];
                    cp.Enlace = link;
                    lista.Add(cp);

                }
                
            }
            catch (Exception ex){
                Debug.WriteLine("Error: "+ex.Message+" - "+ex.StackTrace);
            }
            //var respuestaJson = clienteHttp.GetStringAsync(uri).Result;
            // var resJson = clienteHttp.GetStringAsync(uri).Result;


            /*}
            catch (Exception ex)
            {
                Debug.WriteLine("error: " + ex.Message);
            }*/
        }
    }
}

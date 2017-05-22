
using Cylecar.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;

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
        public async void getData(ListView lista)
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

                var li = s.Replace('\n', '&');
                var lineas = li.Split('&');
                var num = lineas.Length;
                var stringLista = new List<string>();

                foreach (string st in lineas) {
                    stringLista.Add(st);
                }
                var sListaDef = stringLista.Skip(2);
                var nums = stringLista.Count;
                var columnas = lineas[1].Split(';');
                var colNames = columnas.Length;
                //var array = s.Split(';');
                //int count = array.Length;
                //var campos=array.
                //var mytest = s;
                //var myStream = s.GetType();
                //var name = myStream.Name;
                //var x = myStream.ToString();
                //var y = myStream.FullName;
                //var fulname = y;
            /*StreamReader reader = new StreamReader(s, Encoding.GetEncoding("ISO-8859-1"));
                
            System.Text.StringBuilder campo = new StringBuilder();
            int codChar;
            int i = 0;
            List<String[]> filas = new List<string[]>();
            String[] campos = new String[21];
            bool cierraComillas = true; //comillas emparejadas
            bool EOF = false;
            while (!EOF)
            {
                codChar = reader.Read();
                switch (codChar)
                {
                    case -1: //EOF
                        EOF = true;
                        break;
                    case 10: //LF=0A
                        if (cierraComillas)
                        {
                            filas.Add(campos);
                            i = 0;
                            campos = new String[21];
                        }
                        else campo.Append((Char)codChar);
                        break;
                    case 13: //CR=0D (no procede en este caso)

                        break;
                    case 34: //comillas (delimitador de texto)
                        cierraComillas = !cierraComillas;
                        break;
                    case 59: //punto y coma (separador de campos)
                        if (cierraComillas)
                        {
                            campos[i++] = campo.ToString();
                            campo.Clear();
                        }
                        else
                        {
                            campo.Append((Char)codChar);
                        }
                        break;

                    default:
                        campo.Append((Char)codChar);
                        break;
                }
            }
            var resultado = (from punto in filas
                             select new Punto
                             {
                                 Nombre = punto[0],
                                 Datos = punto[2],
                                 Calle = punto[4],
                                 Localidad = punto[6]
                             }).Skip(2); //salto las dos primeras filas y obtengo la colección de puntos de recarga
                                         //la primera fila contiene la fecha de actualización
                                         //la segunda fila contiene los encabezados de los campos
            lista.ItemsSource = resultado;*/
            }
            catch (Exception es){

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

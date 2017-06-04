using Cylecar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylecar.Services
{
    public class SearchService
    {
        List<ChargePoint> resultList;
        public List<ChargePoint> ResultSearch(string filter,List<ChargePoint> listaEstaciones) {
            resultList = new List<ChargePoint>();
            foreach (ChargePoint r in listaEstaciones)
            {
                if (r.Localidad.ToLower().Contains(filter.ToLower()))
                {
                    resultList.Add(r);
                }
                else if (r.Descripcion.ToLower().Contains(filter.ToLower()))
                {

                    resultList.Add(r);
                }
                else if (r.Edificio.ToLower().Contains(filter.ToLower()))
                {
                    resultList.Add(r);
                }
                else if (r.CodigoPostal.Contains(filter))
                {
                    resultList.Add(r);
                }


            }

            return resultList;
        }
    }
}

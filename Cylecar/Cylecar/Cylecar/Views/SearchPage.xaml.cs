using Cylecar.ViewModels;
using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Cylecar.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
       public SearchPage()
        {
            InitializeComponent();
            getPosition();

            //myMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Xamarin.Forms.Maps.Position(latitude, longitude), Distance.FromMiles(1)).WithZoom(20));

        }

        private async void getPosition()
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 100;
            var position = await locator.GetPositionAsync(5000);//se supone que obtiene mi posicion pero obtiene microsoft headquarters
            var goyoPosition = new Position(41.6402549, -4.7344017);
            myMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(goyoPosition.Latitude, goyoPosition.Longitude), Distance.FromKilometers(0.1)));
           Debug.WriteLine("MY POSITION: LATITUDE: "+position.Latitude+" LONGITUDE:"+position.Longitude);
            var pinGoyo = new Pin
            {
                Position = new Position(41.6402549, -4.7344017),
                Address = "Calle de Gabilondo, 23, 47007 Valladolid",
                Label = "Gregorio Fernandez",
                Type = PinType.Place
            };
            myMap.Pins.Add(pinGoyo);

        }
        private async void getPins() {
            
        }
    }

    
}

using Cylecar.Models;
using Cylecar.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Cylecar.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        ChargePoint myCp;
        public DetailPage(ChargePoint cp)
        {
            myCp = cp;
            InitializeComponent();
            BindingContext = cp;
            //LocateMap(myCp);
            myMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(cp.Localizacion.Latitude, cp.Localizacion.Longitude), Distance.FromKilometers(0.1)));
            
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = cp.Localizacion,
                Label = cp.Edificio,
                Address = cp.Enlace
            };

            myMap.Pins.Add(pin);
        }/*
        private void LocateMap(ChargePoint cp) {
            var cpPosition = cp.Localizacion;

            var map = new Map(MapSpan.FromCenterAndRadius(new Position(cpPosition.Latitude, cpPosition.Longitude), Distance.FromKilometers(1.0)))
            {
                IsShowingUser = true,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            
        }*/
    }

    
}

using Cylecar.Models;
using Cylecar.Services;
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
using Xamarin.Forms.Xaml;

namespace Cylecar.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public List<ChargePoint> listaEstaciones { get; set; }
        public ListViewPage()
        {
            InitializeComponent();
            
            JsonContent();
            
            
        }
        public void JsonContent() {
            RestService rs = new RestService();
            listaEstaciones = new List<ChargePoint>();
            rs.getData(listaEstaciones);
            estaciones.ItemsSource = listaEstaciones;
        }

        private void estaciones_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (ChargePoint)e.SelectedItem;
            ((NavigationPage)this.Parent).PushAsync(new DetailPage(e.SelectedItem as ChargePoint));
        }
    }

    
}

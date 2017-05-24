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
            BindingContext = new ContentPageViewModel();
            
        }
        public void JsonContent() {
            RestService rs = new RestService();
            listaEstaciones = new List<ChargePoint>();
            rs.getData(listaEstaciones);
            estaciones.ItemsSource = listaEstaciones;
        }

        
    }

    class ListViewPageViewModel : INotifyPropertyChanged
    {

        public ListViewPageViewModel()
        {
            IncreaseCountCommand = new Command(IncreaseCount);
        }

        int count;

        string countDisplay = "You clicked 0 times.";
        public string CountDisplay
        {
            get { return countDisplay; }
            set { countDisplay = value; OnPropertyChanged(); }
        }

        public ICommand IncreaseCountCommand { get; }

        void IncreaseCount() =>
            CountDisplay = $"You clicked {++count} times";


        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}

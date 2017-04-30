using Cylecar.Views;
using System;

using System.Collections.Generic;

using Xamarin.Forms;


namespace Cylecar
{
    public partial class MainPage : ContentPage
    {
        public List<MenuItemPage> listaMenu { get; set; }
        public MainPage()
        {
            InitializeComponent();

            listaMenu = new List<MenuItemPage>();

            var page1 = new MenuItemPage() { Title = "Estaciones de recarga favoritas", TargetType=null };
            var page2 = new MenuItemPage() { Title = "Busquedas recientes", TargetType = typeof(SearchPage) };
            var page3 = new MenuItemPage() { Title = "Busqueda por ciudades", TargetType = typeof(SearchPage) };
            var page4 = new MenuItemPage() { Title = "Busqueda por provincias", TargetType = typeof(SearchPage) };
            var page5 = new MenuItemPage() { Title = "Creditos", TargetType = typeof(CreditsPage) };
            var page6 = new MenuItemPage() { Title = "Configuracion", TargetType = typeof(ConfigPage) };

            listaMenu.Add(page1);
            listaMenu.Add(page2);
            listaMenu.Add(page3);
            listaMenu.Add(page4);
            listaMenu.Add(page5);
            listaMenu.Add(page6);


            navigationList.ItemsSource = listaMenu;
        }

        private void NavigationList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}

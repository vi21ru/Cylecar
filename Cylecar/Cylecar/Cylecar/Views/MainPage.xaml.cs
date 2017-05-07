using Cylecar.Views;
using System;

using System.Collections.Generic;

using Xamarin.Forms;


namespace Cylecar
{
    public partial class MainPage : MasterDetailPage
    {
        public List<MenuItemPage> listaMenu { get; set; }
        public MainPage()
        {
            InitializeComponent();

            listaMenu = new List<MenuItemPage>();

            var page1 = new MenuItemPage() { Title = "Lista de estaciones", TargetType = typeof(ListViewPage) };
            var page2 = new MenuItemPage() { Title = "Estaciones de recarga favoritas", TargetType=typeof(CreditsPage) };
            var page3 = new MenuItemPage() { Title = "Busquedas recientes", TargetType = typeof(SearchPage) };
            var page4 = new MenuItemPage() { Title = "Busqueda por ciudades", TargetType = typeof(SearchPage) };
            var page5 = new MenuItemPage() { Title = "Busqueda por provincias", TargetType = typeof(SearchPage) };
            var page6 = new MenuItemPage() { Title = "Creditos", TargetType = typeof(CreditsPage) };
            var page7 = new MenuItemPage() { Title = "Configuracion", TargetType = typeof(ConfigPage) };

            listaMenu.Add(page1);
            listaMenu.Add(page2);
            listaMenu.Add(page3);
            listaMenu.Add(page4);
            listaMenu.Add(page5);
            listaMenu.Add(page6);
            listaMenu.Add(page7);


            navigationList.ItemsSource = listaMenu;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(SearchPage)));
        }

        private void NavigationList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MenuItemPage)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}

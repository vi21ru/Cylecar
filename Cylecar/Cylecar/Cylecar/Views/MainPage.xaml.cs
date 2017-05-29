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

            var page1 = new MenuItemPage() { Title = "Inicio", Icon= "home.png", TargetType = typeof(SearchPage) };
            var page2 = new MenuItemPage() { Title = "Lista Estaciones", Icon = "list_choose.png", TargetType=typeof(ListViewPage) };
            var page3 = new MenuItemPage() { Title = "Busqueda estaciones", Icon = "search.png", TargetType = typeof(SearchPage) };
            var page4 = new MenuItemPage() { Title = "Configuracion", Icon = "setting_cog.png", TargetType = typeof(ConfigPage) };
            var page5 = new MenuItemPage() { Title = "Creditos", Icon = "help.png", TargetType = typeof(CreditsPage) };
            

            listaMenu.Add(page1);
            listaMenu.Add(page2);
            listaMenu.Add(page3);
            listaMenu.Add(page4);
            listaMenu.Add(page5);
            //listaMenu.Add(page6);
            //listaMenu.Add(page7);


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

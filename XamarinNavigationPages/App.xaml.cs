using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinNavigationPages
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new XamarinNavigationPages.Inicio.PaginaInicial();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinNavigationPages.Inicio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaInicial : ContentPage
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void MudarPagina(object sender, EventArgs args)
        {
            //App.Current.MainPage = new TipoPagina.Navigation.Pagina1(); //Deste jeito vc substitui a pagina que já havia sido carregada.
            App.Current.MainPage = new NavigationPage(new TipoPagina.Navigation.Pagina1()) { BarBackgroundColor = Color.Chocolate }; //Para a pagina 2 conseguir saber de onde veio (colocar um flexinha) preciso colocar tudo em um NAvigationPage

        }

        private void MudarTabbed(object o, EventArgs e)
        {
            App.Current.MainPage = new Abas.Abas() { BarBackgroundColor = Color.Chocolate };
        }

        private void MudarTabbed2(object o, EventArgs e)
        {
            App.Current.MainPage = new Abas.Abas2();
        }

        private void MudarTabbed3(object o, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new Abas.Abas()) { BarBackgroundColor = Color.DarkGoldenrod };
        }

        private void MudarTabbed4(object o, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new Abas.Abas2()) { BarBackgroundColor = Color.Green };
        }
    }
}
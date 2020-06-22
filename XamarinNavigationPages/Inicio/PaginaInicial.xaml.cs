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
            App.Current.MainPage = new NavigationPage(new TipoPagina.Navigation.Pagina1()) { BarBackgroundColor = Color.Chocolate }; //Para a pagina 2 conseguir saver de onde veio (colocar um flexinha) preciso colocar tudo em um NAvigationPage

        }
    }
}
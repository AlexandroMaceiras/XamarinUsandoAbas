using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinNavigationPages.TipoPagina.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina2 : ContentPage
    {
        public Pagina2()
        {
            InitializeComponent();
        }

        private void MudarPagina3(object o, EventArgs e)
        {
            Title = "Voltou da 3";
            //App.Current.MainPage = new XamarinNavigationPages.TipoPagina.Navigation.Pagina2(); //Esse não mantem o histórico de quem chamou ela.
            Navigation.PushAsync(new Pagina3()); //Esse MANTEM o histórico de quem chamou ela.
        }

        private void VoltarTudo(object o, EventArgs e)
        {
            Title = "Root da 2"; //Não funciona
            Navigation.PopToRootAsync();
        }
    }
}
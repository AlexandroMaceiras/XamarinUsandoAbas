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
    public partial class Pagina1 : ContentPage
    {
        public Pagina1()
        {
            InitializeComponent();
        }
        private void MudarPagina2(object o, EventArgs e)
        {
            Title = "Voltou da 2";
            //App.Current.MainPage = new XamarinNavigationPages.TipoPagina.Navigation.Pagina2(); //Esse não mantem o histórico de quem chamou ela.
            Navigation.PushAsync(new Pagina2()); //Esse MANTEM o histórico de quem chamou ela.
        }

        public void ChamarModal(object o, EventArgs e)
        {
            Navigation.PushModalAsync(new Modal());
        }
    }
}
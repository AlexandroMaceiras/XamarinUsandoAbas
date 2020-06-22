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
    public partial class Modal : ContentPage
    {
        public Modal()
        {
            InitializeComponent();
        }

        private void FecharModal(object o, EventArgs e)
        {
            Navigation.PopModalAsync(); //Este FecharModal é necessário senão vc fica travado no Modal ou então chama um outro Modal ou outro carousel através de outro evento.
        }
    }
}
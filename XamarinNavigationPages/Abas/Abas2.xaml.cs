using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinNavigationPages.Abas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Abas2 : TabbedPage
    {
        public Abas2()
        {
            InitializeComponent();

            Children.Add(new NavigationPage(new TipoPagina.Navigation.Pagina1()) { Title = "Item 3", IconImageSource = "featured.png" });
        }
    }
}
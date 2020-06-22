﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinNavigationPages.TipoPagina.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina3 : ContentPage
    {
        public Pagina3()
        {
            InitializeComponent();
        }

        private void VoltarTudo(object o, EventArgs e)
        {
            try
            {
                Navigation.PopToRootAsync();
                Title = "Root da 3"; //Só funciona na hora que misturar tudo
            }
            catch(Exception err)
            {
                DisplayAlert("Erro", err.Message, "[OK]");
            }
        }
    }
}
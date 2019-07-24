using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaginasXamarinForms.Pagina.Carousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina3 : ContentPage
    {
        public Pagina3()
        {
            InitializeComponent();
        }

        private void MudarPagina (object sender, EventArgs args)
        {
            //App.Current.MainPage = new NavigationPage(new Navigation.Pagina1()) { BarBackgroundColor = Color.Black };
            App.Current.MainPage = new Tabbed.Abas();
        }
    }
}
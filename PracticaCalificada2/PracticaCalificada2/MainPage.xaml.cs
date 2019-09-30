using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PracticaCalificada2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Ejercicio1(object sender, EventArgs e) // Stacklayout
        {
            await Navigation.PushAsync(new pages.Stacklayout());
        }
        private async void Ejercicio2(object sender, EventArgs e) // Grid
        {
            await Navigation.PushAsync(new pages.Grid());
        }
        private async void Ejercicio3(object sender, EventArgs e) // Hierarchical Navigations
        {
            await Navigation.PushAsync(new pages.HierarchicalNavigations());
        }
        private async void Ejercicio4(object sender, EventArgs e) // Tabbed Page
        {
            await Navigation.PushAsync(new pages.TabbedPageE()); 
        }
        private async void Ejercicio5(object sender, EventArgs e) // Formulario
        {
            await Navigation.PushAsync(new pages.Formulario());
        }
        private async void Ejercicio6(object sender, EventArgs e) // Datepicker
        {
            await Navigation.PushAsync(new pages.Stacklayout());
        }


    }
}

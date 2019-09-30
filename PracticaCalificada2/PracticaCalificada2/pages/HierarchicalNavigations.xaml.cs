using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PracticaCalificada2.pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HierarchicalNavigations : ContentPage
	{
		public HierarchicalNavigations ()
		{
			InitializeComponent ();
		}

        private async void Formulario1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pages.Form1());
        }

        private async void Formulario2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pages.Form2());
        }
    }
}
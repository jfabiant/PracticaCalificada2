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
	public partial class Formulario : ContentPage
	{
		public Formulario ()
		{
			InitializeComponent ();
		}

        private void btnSave(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String description = txtDescription.Text;
            DisplayAlert("PracticaCalificada2", "Hello " + name, "ACEPTAR");
        }
    }
}
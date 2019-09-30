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
	public partial class Datepicker : ContentPage
	{
		public Datepicker ()
		{
			InitializeComponent ();
            datePicker.MinimumDate = new DateTime(2019, 1, 1);
            datePicker.MaximumDate = new DateTime(2019, 9, 30);
        }
	}
}
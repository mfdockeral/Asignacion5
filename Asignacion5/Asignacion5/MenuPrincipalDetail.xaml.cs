using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Asignacion5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPrincipalDetail : ContentPage
	{
		public MenuPrincipalDetail()
		{
			InitializeComponent();
		}

		#region EventoBotones
		async private void InformacionPersonalPage_Tapped(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new InformacionPersonal());
		}

		async private void TareasPendientesPage_Tapped(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new TareasPendientes());
		}

		#endregion EventoBotones
	}
}
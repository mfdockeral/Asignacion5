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
	public partial class MenuPrincipal : MasterDetailPage
	{
		public MenuPrincipal()
		{
			InitializeComponent();
			MasterPage.ListView.ItemSelected += ListView_ItemSelected;
		}

		async private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MenuPrincipalMasterMenuItem;

			#region CondicionalesNavegacion

			if (item != null)
			{

				MasterPage.ListView.SelectedItem = null;
				IsPresented = false;

				if (item.Id == 0)
				{

					await Navigation.PushModalAsync(new InformacionPersonal());

				}
				else if (item.Id == 1)
				{
					await Navigation.PushModalAsync(new TareasPendientes());
				}

				#endregion CondicionalesNavegacion

				MasterPage.ListView.SelectedItem = null;
			}
		}	
	}
}
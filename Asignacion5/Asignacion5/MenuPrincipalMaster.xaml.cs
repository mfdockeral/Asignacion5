using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Asignacion5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPrincipalMaster : ContentPage
	{
		public ListView ListView;

		public MenuPrincipalMaster()
		{
			InitializeComponent();

			BindingContext = new MenuPrincipalMasterViewModel();
			ListView = MenuItemsListView;
		}

		class MenuPrincipalMasterViewModel : INotifyPropertyChanged
		{
			public ObservableCollection<MenuPrincipalMasterMenuItem> MenuItems { get; set; }

			#region AsignacionIdElementos
			public MenuPrincipalMasterViewModel()
			{
				MenuItems = new ObservableCollection<MenuPrincipalMasterMenuItem>(new[]
				{
					new MenuPrincipalMasterMenuItem { Id = 0, Title = "Información personal" },
					new MenuPrincipalMasterMenuItem { Id = 1, Title = "Lista de tareas pendientes" },
					
				});
			}

			#endregion AsignacionIdElementos

			#region INotifyPropertyChanged Implementation
			public event PropertyChangedEventHandler PropertyChanged;
			void OnPropertyChanged([CallerMemberName] string propertyName = "")
			{
				if (PropertyChanged == null)
					return;

				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
			#endregion
		}

		#region EventoSeleccionMenuLateral
		private async void MenuItemsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var ItemSeleccionado = e.SelectedItem as MenuPrincipalMasterMenuItem;


			if (ItemSeleccionado == null)
			{
				return;
			}

			if(ItemSeleccionado.Id == 0) {

				await Navigation.PushAsync(new NavigationPage(new InformacionPersonal()));

			}
			else if (ItemSeleccionado.Id == 1)
			{
				await Navigation.PushAsync(new NavigationPage(new TareasPendientes()));
			}

		}

		#endregion EventoSeleccionMenuLateral

	}
}
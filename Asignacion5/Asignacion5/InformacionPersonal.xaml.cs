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
	public partial class InformacionPersonal : ContentPage
	{
		public InformacionPersonal()
		{
			InitializeComponent();
		}

		#region Variables
		async private void BtnGuardarInf_Clicked(object sender, EventArgs e)
		{
			var Nombre = TxtNombre.Text;
			var Apellido = TxtApellido.Text;
			var Nacimiento = TxtNacimiento.Text;
			var Ocupacion = TxtOcupacion.Text;
			DateTime FechaN = fecha.Date;
			var EstadoCivil = SBEstadoCivil.SelectedItem;
			var Genero = SBGenero.SelectedItem;

			#endregion Variables

			#region Condicionales

			if (Nombre != null && Apellido != null && Nacimiento != null && Ocupacion !=null 
				&& FechaN != null && EstadoCivil != null && Genero != null && Nombre != "" 
				&& Apellido != "" && Nacimiento != "" && Ocupacion != "" && FechaN != DateTime.Today) { 

				await DisplayAlert("Los datos guardados son: ", "Nombre: " + Nombre + "\r\n" + "Apellido: " +
					 Apellido + "\r\n" + "Lugar de nacimiento: " + Nacimiento + "\r\n" + "Ocupación: " + Ocupacion +
					 "\r\n" + "Fecha de nacimiento: " + FechaN.ToShortDateString() + "\r\n" + "Estado civil: " 
					 + EstadoCivil + "\r\n" + "Género: " + Genero, "Ok");

				TxtNombre.Text = "";
				TxtApellido.Text = "";
				TxtNacimiento.Text = "";
				TxtOcupacion.Text = "";
				fecha.Date = DateTime.Today;
				SBEstadoCivil.SelectedItem = SBEstadoCivil;
				SBGenero.SelectedItem = SBGenero;

			} 
			else if (Nombre == null || Nombre == "")
			{
				await DisplayAlert("Error", "¡El Campo --Nombre-- no debe estar vacío!", "Ok");
				return;
			}
			else if (Apellido == null || Apellido == "")
			{
				await DisplayAlert("Error", "¡El Campo --Apellido-- no debe estar vacío!", "Ok");
				return;
			}
			else if (Nacimiento == null || Nacimiento == "")
			{
				await DisplayAlert("Error", "¡El Campo --Lugar de Nacimiento-- no debe estar vacío!", "Ok");
				return;
			}
			else if (Ocupacion == null || Ocupacion == "")
			{
				await DisplayAlert("Error", "¡El Campo --Ocupación-- no debe estar vacío!", "Ok");
				return;
			}
			else if (FechaN >= DateTime.Today)
			{
				await DisplayAlert("Error", "¡El Campo --Fecha de Nacimiento-- no debe ser igual o mayor a la fecha actual!", "Ok");
				return;
			}
			else if (EstadoCivil == null)
			{
				await DisplayAlert("Error", "¡Debe seleccionar un --Estado Civil--!", "Ok");
				return;
			}
			else if (Genero == null)
			{
				await DisplayAlert("Error", "¡Debe seleccionar un --Género--!", "Ok");
				return;
			}

			#endregion Condicionales
		}
	}
}
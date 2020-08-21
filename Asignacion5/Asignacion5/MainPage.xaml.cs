using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Asignacion5
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		#region Variables
		async private void BtnIniciar_Clicked(object sender, EventArgs e)
		{
			var Usuario = TxtUser.Text;
			var Contraseña = TxtPassword.Text;

			#endregion Variables

			#region Condicionales

			if (Usuario == "admin@uteco.edu.do" && Contraseña == "Password")
			{
				await DisplayAlert("Inicio de sesión", "¡Sesión iniciada correctamente!", "Ok");
				TxtUser.Text = "";
				TxtPassword.Text = "";

				await Navigation.PushModalAsync(new MenuPrincipal());

			}
			else
			{
				await DisplayAlert("¡Error!", "El usuario o contraseña ingresada no es la correcta," +
					" favor de ingresar un usuario o contraseña válidos.", "Ok");

				TxtUser.Text = "";
				TxtPassword.Text = "";

				return;
			}

			#endregion Condicionales
		}
	}
}

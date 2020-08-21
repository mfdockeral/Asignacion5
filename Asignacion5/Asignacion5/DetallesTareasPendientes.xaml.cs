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
	public partial class DetallesTareasPendientes : ContentPage
	{

		#region EventoAsignaValores
		public DetallesTareasPendientes(DetallesDeTareas tareas)
		{
			InitializeComponent();

			titulo.Text = tareas.Titulo;
			detalle.Text = tareas.Detalle;
			fecha.Text = tareas.Fecha;
			DateTime Fecha = Convert.ToDateTime(fecha.Text);
			int Resta = DateTime.Today.DayOfYear - Fecha.DayOfYear;
			resta.Text = Convert.ToString(Resta);
		}

		#endregion EventoAsignaValores

		#region EventoBoton
		private void Button_Clicked(object sender, EventArgs e)
		{
			DisplayAlert("¡Aviso!","Tarea completada","Ok");
			resta.Text = "0";
			fecha.Text = DateTime.Now.ToString("d");
		}

		#endregion EventoBoton
	}
}
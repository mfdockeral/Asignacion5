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

	#region PropiedadesListView
	public partial class TareasPendientes : ContentPage
	{
		
		public IList<DetallesDeTareas> Tarea { get; private set; }
		public static string Titulo { get; internal set; }
		public static string Detalle { get; internal set; }
		public static String Fecha { get; internal set; }

		#endregion PropiedadesListView

		#region DatosListView
		public TareasPendientes()
		{
			InitializeComponent();

			Tarea = new List<DetallesDeTareas>();
			Tarea.Add(new DetallesDeTareas
			{
				Titulo = "Paginacion y Navegacion",
				Detalle = "Realizar una aplicacion que permita al usuario acceder con usuario y contraseña, " +
				"ver un menu lateral donde le permita elegir entre informacion personal y tareas pendientes.",
				Fecha = "08/25/2020"
			});
			Tarea.Add(new DetallesDeTareas
			{
				Titulo = "Controles Practica 1",
				Detalle = "Crear un proyecto Xamarin Forms y realizar una pantalla que permita al usuario " +
				"ingresar los siguientes datos: Nombre, Apellido, Año de Nacimiento, " +
				"Lugar de Nacimiento y Fecha de Nacimiento, para luego imprimirlos en una alerta.",
				Fecha = "07/14/2020"
			});

			Tarea.Add(new DetallesDeTareas
			{
				Titulo = "Controles Practica 2",
				Detalle = "Realizar la calculadora de un préstamo personal" +
				"Crear un proyecto Xamarin Forms que le permita a un usuario calcular cual seria su cuota de " +
				"pago para un préstamo.",
				Fecha = "07/21/2020"
			});

			BindingContext = this;

			

		}

		#endregion DatosListView

		#region EventoSeleccionDatos
		async private void ListTarea_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var TareaSeleccionada = e.SelectedItem as DetallesDeTareas;

			if (TareaSeleccionada == null)
			{
				return;
			}

			await Navigation.PushAsync(new NavigationPage(new DetallesTareasPendientes (TareaSeleccionada)));
		}

		#endregion EventoSeleccionDatos
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Asignacion5
{

	#region Propiedades
	public class DetallesDeTareas
	{
		public string Titulo { get; set; }
		public string Detalle { get; set; }
		public String Fecha { get; set; }

		public override string ToString()
		{
			return Titulo;
		}
	}
	#endregion Propiedades
}

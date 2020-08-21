using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion5
{

	public class MenuPrincipalMasterMenuItem
	{

		#region PropiedadesMenuLateral
		public MenuPrincipalMasterMenuItem()
		{
			TargetType = typeof(MenuPrincipalMasterMenuItem);
		}
		public int Id { get; set; }
		public string Title { get; set; }

		public Type TargetType { get; set; }
	}

	#endregion PropiedadesMenuLateral

}
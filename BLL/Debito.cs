using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Debito
    {
		private Entidad entidad;
		public Entidad Entidad
		{
			get { return entidad; }
			set { entidad = value; }
		}

		private string detalle;
		public string Detalle
		{
			get { return detalle; }
			set { detalle = value; }
		}

		private float total;
		public float Total
		{
			get { return total; }
			set { total = value; }
		}

		public Debito(Entidad entidad, float total, string detalle = "")
		{
			this.entidad = entidad;
			this.total = total;
			this.detalle = detalle;
		}
	}
}

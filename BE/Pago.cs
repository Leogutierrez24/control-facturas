using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Pago
    {
		private int id;
		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		private DateTime fecha;
		public DateTime Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}

		private float monto;
		public float Monto
		{
			get { return monto; }
			set { monto = value; }
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Debito
    {
		private int id;
		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		private DateTime fechaPresentacion;
		public DateTime FechaPresentacion
		{
			get { return fechaPresentacion; }
			set { fechaPresentacion = value; }
		}

		private float monto;
		public float Monto
		{
			get { return monto; }
			set { if (value >= 0) monto = value; }
		}

		private EstadoDebito estado;					
		public EstadoDebito Estado
		{
			get { return estado; }
			set { estado = value; }
		}

	}
}

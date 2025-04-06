using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class FacturaRechazada : Factura
    {
		private Debito debito;
		public Debito Debito
		{
			get { return debito; }
			set { debito = value; }
		}

	}
}

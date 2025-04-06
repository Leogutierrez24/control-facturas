using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class FacturaPaga : Factura
    {
		private Pago pago;
		public Pago Pago
		{
			get { return pago; }
			set { pago = value; }
		}
	}
}

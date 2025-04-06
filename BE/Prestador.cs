using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Prestador
    {
		private int id;
		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		private string nombre;
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private List<Factura> facturas;
		public List<Factura> Facturas
		{
			get { return facturas; }
			set { facturas = value; }
		}

	}
}

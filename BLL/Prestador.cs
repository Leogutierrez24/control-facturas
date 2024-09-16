using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Prestador
    {
		private string nombre;
		public string Nombre
		{
			get { return Nombre; }
			set { Nombre = value; }
		}

		private string direccion;
		public string Direccion
		{
			get { return direccion; }
			set { direccion = value; }
		}

		private string telefono;
		public string MyProperty
		{
			get { return telefono; }
			set { telefono = value; }
		}

		private string correo;
		public string Correo
		{
			get { return correo; }
			set { correo = value; }
		}

		private List<Factura> facturas = new List<Factura>();
		public List<Factura> Facturas
		{
			get { return facturas; }
		}

		


	}
}

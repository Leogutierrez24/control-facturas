using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Gestor
    {
		private List<Prestador> prestadores;
		public List<Prestador> Prestadores
		{
			get { return prestadores; }
			set { prestadores = value; }
		}

	}
}

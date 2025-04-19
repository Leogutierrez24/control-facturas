using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Factura
    {
		private int id;
		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		private Prestador prestador;
		public Prestador Prestador
		{
			get { return prestador; }
			set { prestador = value; }
		}

		private int puntoVenta;
		public int PuntoVenta
		{
			get { return puntoVenta; }
			set { if (value >= 0) puntoVenta = value; }
		}

		private int numero;
		public int Numero
		{
			get { return numero; }
			set { if (value >= 0) numero = value; }
		}

		private DateTime fechaCreacion;
		public DateTime FechaCreacion
		{
			get { return fechaCreacion; }
			set { fechaCreacion = value; }
		}

        private DateTime fechaRecepcion;
        public DateTime FechaRecepcion
        {
            get { return fechaRecepcion; }
            set { fechaRecepcion = value; }
        }

		private float monto;
		public float Monto
		{
			get { return monto; }
			set { monto = value; }
		}

		private string observacion;
		public string Observacion
		{
			get { return observacion; }
			set { observacion = value; }
		}

		private List<Debito> debitos = new List<Debito>();
		public List<Debito> Debitos
		{
			get { return debitos; }
			set { debitos = value; }
		}

		private List<Pago> pagos = new List<Pago>();
		public List<Pago> Pagos
		{
			get { return pagos; }
			set { pagos = value; }
		}

	}
}

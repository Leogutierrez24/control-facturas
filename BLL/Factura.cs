using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Factura
    {
		private DateTime fechaIngreso;
		public DateTime FechaIngreso
		{
			get { return fechaIngreso; }
			set { fechaIngreso = value; }
		}

		private DateTime fechaEmision;
		public DateTime FechaEmision
		{
			get { return fechaEmision; }
			set { fechaEmision = value; }
		}

		private ushort puntoVenta;
		public ushort PuntoVenta
		{
			get { return puntoVenta; }
		}

		private uint numero;
		public uint Numero
		{
			get { return numero; }
		}

		private float total;
		public float Total
		{
			get { return total; }
		}

		private EstadoFactura estado;
		public EstadoFactura Estado
		{
			get { return estado; }
		}

		private int orderPago;
        public int OrdenPago
        {
            get { return orderPago; }
            set { orderPago = value; }
        }

		private Debito debito;
		public Debito Debito
		{
			get { return debito; }
			set { debito = value; }
		}

		public Factura(ushort puntoVenta, uint numero, DateTime fechaEmision, float total, EstadoFactura estado = EstadoFactura.Pendiente)
		{
			this.puntoVenta = puntoVenta;
			this.numero = numero;
			this.fechaEmision = fechaEmision;
			this.total = total;
			this.estado = estado;
		}

        public Factura(ushort puntoVenta, uint numero, DateTime fechaIngreso, DateTime fechaEmision, float total, EstadoFactura estado = EstadoFactura.Pendiente)
        {
            this.puntoVenta = puntoVenta;
            this.numero = numero;
			this.fechaIngreso = fechaIngreso;
            this.fechaEmision = fechaEmision;
            this.total = total;
            this.estado = estado;
        }

		public void AgregarDebito(Debito debito)
		{
			this.debito = debito;
			total -= debito.Total;
		}

		public void QuitarDebito()
		{
			if (debito != null)
			{
				total += debito.Total;
				debito = null;
			}
		}

		public void ActualizarEstado(EstadoFactura nuevoEstado)
		{
			estado = nuevoEstado;
		}
    }
}

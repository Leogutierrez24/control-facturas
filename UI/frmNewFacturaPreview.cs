using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmNewFacturaPreview : Form
    {
        private BE.Factura nuevaFactura;

        public frmNewFacturaPreview(BE.Factura nuevaFactura)
        {
            InitializeComponent();
            this.nuevaFactura = nuevaFactura;
            ChargeFacturaData();
        }

        private void ChargeFacturaData()
        {
            Prestador_lbl.Text = nuevaFactura.Prestador.Nombre;
            PuntoVenta_textBox.Text = nuevaFactura.PuntoVenta.ToString();
            Numero_textBox.Text = nuevaFactura.Numero.ToString();
            FechaEmision_textBox.Text = nuevaFactura.FechaCreacion.ToShortDateString();
            FechaRecepcion_textBox.Text = nuevaFactura.FechaRecepcion.ToShortDateString();
            Total_textBox.Text = $"${nuevaFactura.Monto}";
        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

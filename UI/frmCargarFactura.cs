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
    public partial class frmCargarFactura : Form
    {
        private List<BE.Prestador> prestadores = new List<BE.Prestador>();

        private BE.Prestador prestador;
        private int puntoVenta;
        private int numero;
        private DateTime fechaIngreso;
        private DateTime fechaFactura;
        private float monto;
        private string observaciones = "";

        public frmCargarFactura(List<BE.Prestador> prestadores)
        {
            InitializeComponent();
            this.prestadores = prestadores;
        }

        private void FiltPrestadores_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PrestadorName_textBox.Text))
            {
                // Filtrar lista de prestadores segun el nombre otorgado.
            }
            else MessageBox.Show("Es necesario un Nombre para continuar.");
        }

        // Error Message Label
        private void ShowErrorMessage(bool visible, string message = "")
        {
            ErrorMessage_label.Visible = visible;
            ErrorMessage_label.Text = message;
        }

        // Punto de venta
        private void PuntoVenta_textBox_TextChanged(object sender, EventArgs e)
        {
            puntoVenta = int.Parse(PuntoVenta_textBox.Text);
        }

        private void PuntoVenta_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PuntoVenta_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PuntoVenta_checkBox.Checked == true)
            {
                PuntoVenta_textBox.Text = "";
                PuntoVenta_textBox.Enabled = false;
                puntoVenta = 0;
            } else
            {
                PuntoVenta_textBox.Enabled = true;
            }
        }
        
        // Numero de la factura
        private void Numero_textBox_TextChanged(object sender, EventArgs e)
        {
            int result = int.Parse(Numero_textBox.Text);
            if (result != 0)
            {
                numero = result;
                if (ErrorMessage_label.Visible) ShowErrorMessage(false);
            }
            else ShowErrorMessage(true, "¡El número de la factura debe ser mayor que cero!");

        }

        private void Numero_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Fecha de recepcion
        private void FechaRecepcion_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            fechaIngreso = FechaRecepcion_dateTimePicker.Value;
        }

        // Fecha de emision de la factura
        private void FechaFactura_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            fechaFactura = FechaFactura_dateTimePicker.Value;
        }

        // Monto
        private void Monto_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Monto_numericUpDown.Value > 0)
            {
                monto = (float)Monto_numericUpDown.Value;
                if (ErrorMessage_label.Visible) ShowErrorMessage(false);
            }
            else ShowErrorMessage(true, "¡El monto de la factura debe ser mayor que cero!");
        }
    }
}

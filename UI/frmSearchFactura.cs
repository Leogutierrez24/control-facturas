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
    internal enum FilterOptions
    {
        PUNTO_DE_VENTA = 0,
        NUMERO = 1,
        MONTO = 2,
        PAGAS = 3,
        PENDIENTE = 4,
        RECHAZADAS = 5,
        DEBITADAS = 6,
        VENCIDAS = 7,
    }

    public partial class frmSearchFactura : Form
    {
        public frmSearchFactura()
        {
            InitializeComponent();
            ChargeFilterOptions();
        }

        private void ChargeFilterOptions()
        {
            FilterOptions_comboBox.Items.Add("Punto de Venta");
            FilterOptions_comboBox.Items.Add("Número");
            FilterOptions_comboBox.Items.Add("Monto");
            FilterOptions_comboBox.Items.Add("Pagas");
            FilterOptions_comboBox.Items.Add("Pendientes");
            FilterOptions_comboBox.Items.Add("Rechazadas");
            FilterOptions_comboBox.Items.Add("Debitada");
            FilterOptions_comboBox.Items.Add("Vencidas");
            FilterOptions_comboBox.SelectedIndex = 0;
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FilterOptions_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterOptions_comboBox.SelectedIndex > 2)
            {
                Search_textBox.Enabled = false;
                Search_textBox.Text = string.Empty;
            }
            else
            {
                Search_textBox.Enabled = true;
            }
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            int searchSelectedOption = FilterOptions_comboBox.SelectedIndex;
            if (searchSelectedOption != -1)
            {
                if (searchSelectedOption < 3 && !string.IsNullOrWhiteSpace(Search_textBox.Text))
                {
                    if (searchSelectedOption < 2 && int.TryParse(Search_textBox.Text, out int intResult))
                    {
                        MessageBox.Show("El valor ingresado es: " + intResult);
                    }
                    else if (searchSelectedOption == 2 && float.TryParse(Search_textBox.Text, out float floatResult))
                    {
                        MessageBox.Show("El valor ingresado es: " + floatResult);
                    }
                    else MessageBox.Show("El valor ingresado debe ser numérico.");
                }
                else if (searchSelectedOption > 2)
                {

                } else MessageBox.Show("Es necesario ingresar un valor para la busqueda.");
            } else MessageBox.Show("Elegi una opcion de filtro para continuar.");
        }
    }
}

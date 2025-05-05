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
    public partial class frmHome : Form
    {
        private readonly BLL.ServicePrestador servicePrestador;

        public List<BE.Prestador> prestadores = new List<BE.Prestador>(); 

        public frmHome()
        {
            InitializeComponent();
            servicePrestador = BLL.ServicePrestador.GetInstance();
            prestadores = servicePrestador.GetAll();
            FiltPrestadores();
        }

        private void LoadPrestadores()
        {
            Prestadores_dataGridView.DataSource = null;
            Prestadores_dataGridView.DataSource = prestadores;
        }

        private void LoadPrestadores(List<BE.Prestador> filteredList)
        {
            Prestadores_dataGridView.DataSource = null;
            Prestadores_dataGridView.DataSource = filteredList;
        }

        private void FiltPrestadores()
        {
            if (Option01_radioButton.Checked)
            {
                prestadores.OrderBy(p => p.Nombre);
                LoadPrestadores();
            }
            else if (Option02_radioButton.Checked) 
            {
                prestadores.OrderByDescending(p => p.Nombre);
                LoadPrestadores();
            }
            else
            {
                if (!string.IsNullOrEmpty(Filter_lbl.Text))
                {
                    List<BE.Prestador> filteredList = prestadores.FindAll(p => p.Nombre.Contains(Filter_lbl.Text));
                    LoadPrestadores(filteredList);
                }
                else MessageBox.Show("El campo de busqueda vacio!!!");
            }
        }

        private void RadioButtonsObserver()
        {
            if (Option03_radioButton.Checked)
            {
                Filter_lbl.Enabled = true;
                Filter_textBox.Enabled = true;

                if (Option03_radioButton.Checked)
                {
                    Filter_lbl.Text = "Nombre:";
                } else Filter_lbl.Text = "Punto de venta:";
            }

            if (!Option03_radioButton.Checked && (Filter_lbl.Enabled || Filter_textBox.Enabled))
            {
                Filter_lbl.Enabled = false;
                Filter_textBox.Enabled = false;
                Filter_lbl.Text = string.Empty;
            }
        }

        private void Option01_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonsObserver();
        }

        private void Option02_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonsObserver();
        }

        private void Option03_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonsObserver();
        }

        private void Filt_btn_Click(object sender, EventArgs e)
        {
            FiltPrestadores();
        }

        private void NuevoPrestador_btn_Click(object sender, EventArgs e)
        {
            frmNuevoPrestador form = new frmNuevoPrestador(servicePrestador, prestadores);
            form.ShowDialog();
            LoadPrestadores();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }
    }
}

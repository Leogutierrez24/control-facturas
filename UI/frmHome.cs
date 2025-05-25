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
            LoadPrestadores();
        }

        private void ConfigDataGridView()
        {
            Prestadores_dataGridView.Columns[0].Visible = false;
            Prestadores_dataGridView.Columns[1].Width = 300;
            Prestadores_dataGridView.Columns[2].Width = 105;
            Prestadores_dataGridView.Columns[2].HeaderText = "Punto de Venta";
        }

        private void LoadPrestadores()
        {
            Prestadores_dataGridView.DataSource = null;
            Prestadores_dataGridView.DataSource = prestadores;
            ConfigDataGridView();
        }

        private void LoadPrestadores(List<BE.Prestador> filteredList)
        {
            Prestadores_dataGridView.DataSource = null;
            Prestadores_dataGridView.DataSource = filteredList;
            ConfigDataGridView();
        }

        private void FiltPrestadores()
        {
            List<BE.Prestador> filteredList = new List<BE.Prestador>();

            if (Option01_radioButton.Checked)
            {
                filteredList = prestadores.OrderBy(p => p.Nombre).ToList();
                LoadPrestadores(filteredList);
            }
            else if (Option02_radioButton.Checked) 
            {
                filteredList = prestadores.OrderByDescending(p => p.Nombre).ToList();
                LoadPrestadores();
            }
            else
            {
                if (!string.IsNullOrEmpty(Filter_textBox.Text))
                {
                    prestadores.ForEach(p =>
                    {
                        if (p.Nombre.Contains(Filter_textBox.Text.ToUpper()))
                        {
                            filteredList.Add(p);
                        }
                    });
                    LoadPrestadores(filteredList);
                }
                else MessageBox.Show("El campo de busqueda vacio!!!");
            }
        }

        // Filter
        // Filter Operations
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


        // Filter Buttons
        private void Filt_btn_Click(object sender, EventArgs e)
        {
            FiltPrestadores();
        }

        private void Rollback_btn_Click(object sender, EventArgs e)
        {
            Option01_radioButton.Checked = true;
            FiltPrestadores();
        }

        // Prestadores
        // Prestadores buttons
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

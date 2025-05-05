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
    public partial class frmNuevoPrestador : Form
    {
        private string nombre;
        private int puntoVenta;
        private readonly List<BE.Prestador> prestadoresList = new List<BE.Prestador>();
        private readonly BLL.ServicePrestador service;

        public frmNuevoPrestador(BLL.ServicePrestador service, List<BE.Prestador> prestadoresList)
        {
            InitializeComponent();
            nombre = prestadorNombre_textBox.Text;
            puntoVenta = Convert.ToInt16(puntoVenta_numericUpDown.Value);
            this.service = service;
            this.prestadoresList = prestadoresList;
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetMessageErrorLabel()
        {
            ErrorMessage_lbl.Text = string.Empty;
            ErrorMessage_lbl.Visible = false;
        }

        private void SetMessageErrorLabel(string error)
        {
            ErrorMessage_lbl.Visible = true;
            ErrorMessage_lbl.Text = error;
        }

        private void Registrar_btn_Click(object sender, EventArgs e)
        {
            ResetMessageErrorLabel();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                SetMessageErrorLabel("El campo de nombre esta vacio.");
            } else
            {
                if (!prestadoresList.Exists(p => p.Nombre == nombre.ToUpper()))
                {
                    BE.Prestador newPrestador = new BE.Prestador
                    {
                        Nombre = nombre,
                        PuntoVenta = puntoVenta
                    };
                    int result = service.LoadPrestador(newPrestador);
                    if (result == 0)
                    {
                        MessageBox.Show($"Se agrego al prestador: {nombre.ToUpper()}");
                        this.Close();
                    }
                    else MessageBox.Show("Error al intentar registrar prestador.");
                } else
                {
                    MessageBox.Show("Ya existe un prestador registrado con ese nombre.");
                }
            }
        }

        private void frmNuevoPrestador_Load(object sender, EventArgs e)
        {
            ResetMessageErrorLabel();
        }

        private void prestadorNombre_textBox_TextChanged(object sender, EventArgs e)
        {
            nombre = prestadorNombre_textBox.Text;
        }

        private void puntoVenta_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            puntoVenta = Convert.ToInt16(puntoVenta_numericUpDown.Value);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFConClasesyFuncionesCadena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ClaseWF ejer1 = new ClaseWF();
            ejer1.Legajo = int.Parse(txtLegajo.Text);
            ejer1.Nombre = txtNombre.Text;
            ejer1.Apellido = txtApellido.Text;
            ejer1.GenerarConcatenado();
            ejer1.GenerarLargo();

            txtConcatenado.Text = ejer1.Concatenado;
            txtLargo.Text = ejer1.Largo;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtLegajo.Text = "";
            txtApellido.Clear();
            txtNombre.Clear();
            txtConcatenado.Clear();
            txtLargo.Clear();
            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

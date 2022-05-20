using System;
using System.Collections.Generic; 
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFConCollecciones
{
    
    public partial class Form1 : Form
    {
        List<Persona> listaPersona = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Persona per1 = new Persona();
            per1.Nombre = txtNombre.Text;
            per1.Apellido = txtApellido.Text;
            per1.Edad = int.Parse(txtEdad.Text);
            listaPersona.Add(per1);

            dgvPersona.DataSource = null;
            dgvPersona.DataSource = listaPersona;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            txtNombre.Focus();
        }
    }
}

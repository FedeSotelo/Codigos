using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciaConWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //limpiar los controles y hacer foco en el nombre
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Persona per1 = new Persona();
            per1.Apellido = txtApellido.Text;
            per1.Nombre = txtNombre.Text;
            per1.Documento = txtDocu.Text;
            //terminar de instanciar y cargar datos


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

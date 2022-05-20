using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejer1Wewb
{
    public partial class Pagina4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            txtNro1.Text = "";
            txtNro2.Text = "";
            LblResultado.Text = "";
            rdbResta.Checked = false;
            rdbSuma.Checked = false;



        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            int nro1 = int.Parse(txtNro1.Text);
            int nro2 = int.Parse(txtNro2.Text);
            if (rdbSuma.Checked == true)
            {
                int suma = nro1 + nro2;

                LblResultado.Text = $"El resultado es " + suma.ToString();
            }
            else if(rdbSuma.Checked == false)
            {
                int resta = nro1 - nro2;
                LblResultado.Text = "El resultado es " + resta.ToString();
            }


            
        }
    }
}
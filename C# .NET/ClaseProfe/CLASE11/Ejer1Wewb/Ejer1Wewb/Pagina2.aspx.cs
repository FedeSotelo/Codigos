using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejer1Wewb
{
    public partial class Pagina2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString("d");
            Label2.Text = DateTime.Now.ToString("D");
            Label3.Text = DateTime.Now.ToString("T");
        }
    }
}
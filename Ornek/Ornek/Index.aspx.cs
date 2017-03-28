using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ornek
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHasta_Click(object sender, EventArgs e)
        {
            Response.Redirect("Hasta.aspx");
        }

        protected void btnDoktor_Click(object sender, EventArgs e)
        {
            Response.Redirect("Doktor.aspx");
        }

        protected void btnAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }
    }
}
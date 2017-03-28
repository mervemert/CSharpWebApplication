using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ornek
{
    public partial class masterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHasta_Click(object sender, EventArgs e)
        {
            Response.Redirect("Hasta.aspx");
        }

        protected void btnHekim_Click(object sender, EventArgs e)
        {
            Response.Redirect("Doktor.aspx");
        }

        protected void btnAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }
    }
}
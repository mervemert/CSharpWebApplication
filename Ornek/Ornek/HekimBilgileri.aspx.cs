using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ornek
{
    public partial class HekimBilgileri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_RandevuGor_Click(object sender, EventArgs e)
        {
            Response.Redirect("HekimRandevulari.aspx");
        }
    }
}
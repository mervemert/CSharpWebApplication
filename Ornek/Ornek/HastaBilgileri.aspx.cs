using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Ornek
{
    public partial class HastaBilgileri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRandevuAl_Click(object sender, EventArgs e)
        {
            Response.Redirect("RandevuAl.aspx");
        }

        protected void btnRandevuGuncelle_Click(object sender, EventArgs e)
        {
            Response.Redirect("RandevuGuncelle.aspx");
        }

        protected void btnGecmisRandevu_Click(object sender, EventArgs e)
        {
            Response.Redirect("GecmisRandevu.aspx");
        }

        protected void btnDoktorBilgileri_Click(object sender, EventArgs e)
        {
            Response.Redirect("HekimBilgileri.aspx");
        }

        protected void btnHesapBilgileri_Click(object sender, EventArgs e)
        {
            Response.Redirect("HesapBilgileri.aspx");
        }

        protected void btnCikisYap_Click(object sender, EventArgs e)
        {
            Response.Redirect("Hasta.aspx");
        }
    }
}
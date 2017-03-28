using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Ornek
{
    public partial class GecmisRandevu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                veriBagla();
            }

        }
        private void veriBagla()
        {

            SqlConnection con = new SqlConnection("Data Source=MERVE;Initial Catalog=HTS;Integrated Security=true");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

 
            SqlCommand cmd = new SqlCommand("select * from Randevu", con);
            da.SelectCommand = cmd;
            da.Fill(dt);
               
            gridGecmisRandevu.DataSource = dt;
            gridGecmisRandevu.DataBind();
                
               
     
        }

        protected void geriDon_Click(object sender, EventArgs e)
        {
            Response.Redirect("HastaBilgileri.aspx");
        }
    }
}
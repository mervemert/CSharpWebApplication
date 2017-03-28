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
    public partial class Admin : System.Web.UI.Page
    {
        SqlConnection baglan = new SqlConnection("Data Source=MERVE;Initial Catalog=HTS;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_girisAdmin_Click(object sender, EventArgs e)
        {
            baglan.Open();
            cmd.Connection = baglan;
            cmd.CommandText = "select * from Admin where Sifre='" + txt_sifreAdmin.Text + "'";
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                Session["Sifre"] = txt_sifreAdmin.Text ;
                Response.Redirect("AdminForm.aspx");
            }
            else
            {
                Response.Write("hatalı giriş");
            }

            baglan.Close();

        }
    }
}
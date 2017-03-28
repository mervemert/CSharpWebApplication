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
    public partial class Doktor : System.Web.UI.Page
    {
        SqlConnection baglan = new SqlConnection("Data Source=MERVE;Initial Catalog=HTS;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_girisHekim_Click(object sender, EventArgs e)
        {
            baglan.Open();
            cmd.Connection = baglan;
            cmd.CommandText = "select * from HekimGiris where TcNo='" + txt_tcHekim.Text + "'and Sifre='" + txt_sifreHekim.Text + "'";
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                Session["TcNo"] = txt_tcHekim.Text;
                Session["Sifre"] = txt_sifreHekim.Text;
                Response.Redirect("HekimBilgileri.aspx");
            }
            else
            {
                Response.Write("hatalı giriş");
            }

            baglan.Close();
           
        }
    }
}
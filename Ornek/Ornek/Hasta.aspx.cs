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
    public partial class Hasta : System.Web.UI.Page
    {
        SqlConnection baglan = new SqlConnection("Data Source=MERVE;Initial Catalog=HTS;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_giris_Click(object sender, EventArgs e)
        {
            baglan.Open();
            cmd.Connection = baglan;
            cmd.CommandText = "select * from Uye where TcNo='" + txt_tc.Text + "'and Sifre='" + txt_sifre.Text + "'";
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                Session["TcNo"] = txt_tc.Text;
                Session["Sifre"] = txt_sifre.Text;
                cleartext();
                Response.Redirect("HastaBilgileri.aspx");
            }
            else
            {
                this.lblgiris.ForeColor = System.Drawing.Color.Red;
                this.lblgiris.Text = "TC Kimlik Numarası veya Şifre Hatalı!";
            }

            baglan.Close();
        }

        public void cleartext()
        {
            txt_tc.Text = "";
            txt_sifre.Text = "";

        }

        protected void btn_uyeKayit_Click(object sender, EventArgs e)
        {
            Response.Redirect("UyeKaydi.aspx");
        }

        protected void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            Response.Redirect("SifremiUnuttum.aspx");
        }

        
    }
}
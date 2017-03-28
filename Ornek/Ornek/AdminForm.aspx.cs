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
    public partial class AdminForm : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=MERVE;initial Catalog=HTS;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if(!IsPostBack)
            {
                display();
            }*/
        }

        protected void btnekle_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "insert into Uye(TcNo,Sifre,Adi,Soyadi,Cinsiyet,DogumYeri,Tel,Email,DogumTarihi) values('"+txttc.Text+"','" +txtsifre.Text+"','"+txtad.Text+"','"+txtsoyad.Text+"','"+txtcins.Text+"','"+txtdyer.Text+"','"+txttel.Text+"','"+txtmail.Text+"','"+txtdtarih.Text+"')";
           SqlCommand cmd = new SqlCommand(str,con);
            cmd.ExecuteNonQuery();
            con.Close();
            cleartext();
        }

        protected void linkSec_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            Session["id"] = btn.CommandArgument;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Uye", con);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            if(dt.Rows.Count >= 0)
            {
                txttc.Text = dt.Rows[0]["TcNo"].ToString();
                txtsifre.Text = dt.Rows[0]["Sifre"].ToString();
                txtad.Text = dt.Rows[0]["Adi"].ToString();
                txtsoyad.Text = dt.Rows[0]["Soyadi"].ToString();
                txtcins.Text = dt.Rows[0]["Cinsiyet"].ToString();
                txtdyer.Text = dt.Rows[0]["DogumYeri"].ToString();
                txttel.Text = dt.Rows[0]["Tel"].ToString();
                txtmail.Text = dt.Rows[0]["Email"].ToString();
                txtdtarih.Text = dt.Rows[0]["DogumTarihi"].ToString();
            }

            con.Close();

        }

        public void display ()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Uye", con);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            gridcrud.DataSource = dt;
            gridcrud.DataBind();
            con.Close();
        }

        protected void btnguncelle_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "update Uye set TcNo ='" +txttc.Text+"',Sifre ='" + txtsifre.Text + "',Adi ='" + txtad.Text + "',Soyadi='" + txtsoyad.Text + "',Cinsiyet='" + txtcins.Text +"',DogumYeri='" + txtdyer.Text + "',Tel='" + txttel.Text + "',Email='" + txtmail.Text + "',DogumTarihi='" + txtdtarih.Text + "' where UyeID='" + Session["id"] + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
            cleartext();
           

        
        }

        protected void btnsil_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Uye  where UyeID='"+Session["id"]+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void cleartext()
        {
            txttc.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            txtcins.Text = "";
            txtdtarih.Text = "";
            txtdyer.Text = "";
            txtmail.Text = "";
            txtsifre.Text = "";
            txttel.Text = "";

        }

        protected void btnlistele_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Uye", con);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            gridcrud.DataSource = dt;
            gridcrud.DataBind();
            con.Close();
        }
    
    }
}
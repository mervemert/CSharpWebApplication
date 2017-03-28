using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Drawing;
using System.Configuration;

namespace Ornek
{
    public partial class SifremiUnuttum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGonder_Click(object sender, EventArgs e)
        {
        string tcno = string.Empty;
    string sifre = string.Empty;
    string constr = "Data Source=MERVE;Initial Catalog=HTS;Integrated Security=True";
    using (SqlConnection con = new SqlConnection(constr))
    {
        using (SqlCommand cmd = new SqlCommand("SELECT TcNo, Sifre FROM Uye WHERE Email = @Email"))
        {
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
            cmd.Connection = con;
            con.Open();
            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                if (sdr.Read())
                {
                    tcno = sdr["Tcno"].ToString();
                    sifre = sdr["Sifre"].ToString();
                }
            }
            con.Close();
        }
    }
    if (!string.IsNullOrEmpty(sifre))
    {
        MailMessage mm = new MailMessage("sender@gmail.com", txtEmail.Text.Trim());
        mm.Subject = "Password Recovery";
        mm.Body = string.Format("Hi {0},<br /><br />Your password is {1}.<br /><br />Thank You.", tcno, sifre);
        mm.IsBodyHtml = true;
       SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.EnableSsl = false;
        NetworkCredential NetworkCred = new NetworkCredential();
        NetworkCred.UserName = "sender@gmail.com";
        NetworkCred.Password = "<Sifre>";
        smtp.UseDefaultCredentials = true;
        smtp.Credentials = NetworkCred;
        smtp.Port = 587;
        smtp.Send(mm);
        lblMesaj.ForeColor = Color.Green;
        lblMesaj.Text = "Password has been sent to your email address.";
    }
    else
    {
        lblMesaj.ForeColor = Color.Red;
        lblMesaj.Text = "This email address does not match our records.";
    }
            
           
        }

    }
}
   

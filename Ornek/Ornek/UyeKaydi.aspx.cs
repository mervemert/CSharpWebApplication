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
    public partial class UyeKaydi : System.Web.UI.Page
    {
        string yol = @"Data Source=MERVE;initial Catalog=HTS;integrated security=true";
        SqlConnection baglanti;
        SqlCommand cmd;
     

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void txt_kaydet_Click(object sender, EventArgs e)
        {
            string tcno, sifre, ad, soyad, cinsiyet, dogumYeri, dogumTarihi, tel, email;


            tcno = this.txt_tc.Text;
            sifre = this.txt_sifre.Text;
            ad = this.txt_adi.Text;
            soyad = this.txt_soyadi.Text;
            cinsiyet = rblist_cins.SelectedItem.Text.ToString();
            dogumYeri = this.txt_dYeri.Text;
            
            tel = this.txt_tel.Text;
            email = this.txt_mail.Text;
            dogumTarihi = this.txt_dTarihi.Text;


            baglanti = new SqlConnection(yol);
            baglanti.Open();
            string ekle = "insert into Uye (TcNo,Sifre,Adi,Soyadi,Cinsiyet,DogumYeri,DogumTarihi,Tel,Email) values ('" + tcno + "','" + sifre + "','" + ad + "','" + soyad + "','" + cinsiyet + "','" + dogumYeri + "','" + dogumTarihi.ToString() + "','" + tel + "','" + email + "')";
            cmd = new SqlCommand(ekle, baglanti);
            cmd.ExecuteNonQuery();


            Response.Write("Kayıt Başarılı");
            Response.Redirect("Hasta.aspx");
 
        }
      }
    }

    

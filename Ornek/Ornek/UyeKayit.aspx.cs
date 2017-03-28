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
    public partial class UyeKayit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string yol = @"Data Source=MMERT;initial Catalog=Randevu;integrated security=true";
        SqlConnection baglanti;
        SqlCommand cmd;
        

        protected void txt_kaydet_Click(object sender, EventArgs e)
        {
            string tcno, sifre, ad, soyad, cinsiyet, dogumYeri, dogumTarihi, tel, email;
           

            tcno = this.txt_tc.Text;
            sifre = this.txt_sifre.Text;
            ad = this.txt_adi.Text;
            soyad = this.txt_soyadi.Text;
            cinsiyet = RadioButtonList1.SelectedItem.Text.ToString();
            dogumYeri = this.txt_dYeri.Text;
            dogumTarihi = this.Calendar1.SelectedDate.ToShortDateString();
            tel = this.txt_tel.Text;
            email = this.txt_mail.Text;
            
            

            baglanti = new SqlConnection(yol);
            baglanti.Open();
            string ekle = "insert into uye (tcno,sifre,ad,soyad,cinsiyet,dogumYeri,dogumTarihi,tel,email) values ('" + tcno + "','" + sifre + "','" + ad + "','" + soyad + "','" + cinsiyet + "','" + dogumYeri + "','" + dogumTarihi.ToString()+ "','" + tel + "','" + email + "')";
            cmd = new SqlCommand(ekle, baglanti);
            cmd.ExecuteNonQuery();

            Response.Write("Kayıt Eklendi");

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            lbl_tarih.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        
    }
}
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
    public partial class RandevuAl : System.Web.UI.Page
    {



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ddlIlce.AppendDataBoundItems = true;
                String strConnString = @"Data Source=MERVE;Initial Catalog=HTS;Integrated Security=True";
                String strQuery = "select IlceID, IlceAdi from Ilceler";
                SqlConnection con = new SqlConnection(strConnString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strQuery;
                cmd.Connection = con;
                try
                {
                    con.Open();
                    ddlIlce.DataSource = cmd.ExecuteReader();
                    ddlIlce.DataTextField = "IlceAdi";
                    ddlIlce.DataValueField = "IlceID";
                    ddlIlce.DataBind();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }
            }
        }

        protected void ddlIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlHastane.Items.Clear();
            ddlHastane.Items.Add(new ListItem("--Hastane Seç--", ""));
            ddlKlinik.Items.Clear();
            ddlKlinik.Items.Add(new ListItem("--Klinik Seç--", ""));

            ddlHastane.AppendDataBoundItems = true;
            String strConnString = @"Data Source=MERVE;Initial Catalog=HTS;Integrated Security=True";
            String strQuery = "select HastaneID, HastaneAdi from Hastaneler " +
                               "where IlceID=@IlceID";
            SqlConnection con = new SqlConnection(strConnString);
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IlceID",
                ddlIlce.SelectedItem.Value);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strQuery;
            cmd.Connection = con;
            try
            {
                con.Open();
                ddlHastane.DataSource = cmd.ExecuteReader();
                ddlHastane.DataTextField = "HastaneAdi";
                ddlHastane.DataValueField = "HastaneID";
                ddlHastane.DataBind();
                if (ddlHastane.Items.Count > 1)
                {
                    ddlHastane.Enabled = true;
                }
                else
                {
                    ddlHastane.Enabled = false;
                    ddlKlinik.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        protected void ddlHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlKlinik.Items.Clear();
            ddlKlinik.Items.Add(new ListItem("--Klinik Seç--", ""));
            ddlKlinik.AppendDataBoundItems = true;
            String strConnString = @"Data Source=MERVE;Initial Catalog=HTS;Integrated Security=True";
            String strQuery = "select KlinikID, KlinikAdi from Klinikler " +
                                        "where HastaneID=@HastaneID";
            SqlConnection con = new SqlConnection(strConnString);
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@HastaneID",
                                  ddlHastane.SelectedItem.Value);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strQuery;
            cmd.Connection = con;
            try
            {
                con.Open();
                ddlKlinik.DataSource = cmd.ExecuteReader();
                ddlKlinik.DataTextField = "KlinikAdi";
                ddlKlinik.DataValueField = "KlinikID";
                ddlKlinik.DataBind();
                if (ddlKlinik.Items.Count > 1)
                {
                    ddlKlinik.Enabled = true;
                }
                else
                {
                    ddlKlinik.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        protected void ddlKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlKlinikYeri.Items.Clear();
            ddlKlinikYeri.Items.Add(new ListItem("--Klinik Yeri Seç--", ""));
            ddlKlinikYeri.AppendDataBoundItems = true;
            String strConnString = @"Data Source=MERVE;Initial Catalog=HTS;Integrated Security=True";
            String strQuery = "select KlinikYeriID, KlinikYerAdi from KlinikYeri " +
                                        "where KlinikID=@KlinikID";
            SqlConnection con = new SqlConnection(strConnString);
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@KlinikID",
                                  ddlKlinik.SelectedItem.Value);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strQuery;
            cmd.Connection = con;
            try
            {
                con.Open();
                ddlKlinikYeri.DataSource = cmd.ExecuteReader();
                ddlKlinikYeri.DataTextField = "KlinikYerAdi";
                ddlKlinikYeri.DataValueField = "KlinikYeriID";
                ddlKlinikYeri.DataBind();
                if (ddlKlinikYeri.Items.Count > 1)
                {
                    ddlKlinikYeri.Enabled = true;
                }
                else
                {
                    ddlKlinikYeri.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        protected void ddlKlinikYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlHekim.Items.Clear();
            ddlHekim.Items.Add(new ListItem("--Hekim Seç--", ""));
            ddlHekim.AppendDataBoundItems = true;
            String strConnString = @"Data Source=MERVE;Initial Catalog=HTS;Integrated Security=True";
            String strQuery = "select HekimID, HekimAdi, HekimSoyadi from Hekim " +
                                        "where KlinikYeriID=@KlinikYeriID";
            SqlConnection con = new SqlConnection(strConnString);
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@KlinikYeriID",
                                  ddlKlinikYeri.SelectedItem.Value);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strQuery;
            cmd.Connection = con;
            try
            {
                con.Open();
                ddlHekim.DataSource = cmd.ExecuteReader();
                ddlHekim.DataTextField = "HekimSoyadi";
                ddlHekim.DataTextField = "HekimAdi";
                ddlHekim.DataValueField = "HekimID";
                ddlHekim.DataBind();
                if (ddlHekim.Items.Count > 1)
                {
                    ddlHekim.Enabled = true;
                }
                else
                {
                    ddlHekim.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        protected void btnRandevuAra_Click(object sender, EventArgs e)
        {
            String strConnString = @"Data Source=MERVE;Initial Catalog=HTS;Integrated Security=True";
            SqlConnection con = new SqlConnection(strConnString);

            string sorgu = "select * from Hekim";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            this.gridHekim.DataSource = ds.Tables[0];
            this.gridHekim.DataBind();

            try
            {
                int hekimId = Convert.ToInt32(ddlHekim.SelectedValue);
                GridGoster(hekimId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void GridGoster(Int32 hekimId)
        {
            SqlConnection con = new SqlConnection("Data Source=MERVE;Initial Catalog=HTS;Integrated Security=true");
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                SqlCommand cmd = new SqlCommand("select *  from Hekim where HekimID=" + hekimId + " ", con);
                adp.SelectCommand = cmd;
                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    gridHekim.DataSource = dt;
                    gridHekim.DataBind();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dt.Clear();
                dt.Dispose();
                adp.Dispose();
            }
        }


        protected void gridSaatGoster(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "SaatSec")
            {
                try
                {
                    DateTime d1 = new DateTime(2013, 8, 10, 9, 0, 0);
                    DateTime d2 = new DateTime(2013, 8, 10, 12, 0, 0);

                    for (int i = d1.Hour; i < d2.Hour; i++)
                    {
                        for (int j = 0; j < 60; j = j + 10)
                        {
                            ListItem li = new ListItem();

                            if (j < 10)
                            {
                                li.Text = i.ToString() + ":0" + j.ToString();
                            }

                            else
                            {
                                li.Text = i.ToString() + ":" + j.ToString();
                            }
                            radioBtnList.Items.Add(li);

                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }


        }

        protected void btnRandevuKaydet_Click(object sender, EventArgs e)
        {
            string yol = @"Data Source=MERVE;Initial Catalog=HTS;Integrated Security=True";
            SqlConnection con = new SqlConnection(yol);
            SqlCommand cmd;

            string ilce, hastane, klinik, klinikYeri, hekim, saat;

            ilce = ddlIlce.SelectedItem.Text.ToString();
            hastane = ddlHastane.SelectedItem.Text.ToString();
            klinik = ddlKlinik.SelectedItem.Text.ToString();
            klinikYeri = ddlKlinikYeri.SelectedItem.Text.ToString();
            hekim = ddlHekim.SelectedItem.Text.ToString();
            saat = radioBtnList.SelectedItem.Text.ToString();
            try
            {
                con.Open();
                string ekle = "insert into Randevu (Ilce,Hastane,Klinik,KlinikYeri,Hekim,Saat)" +
                "values ('" + ilce + "','" + hastane + "','" + klinik + "','" + klinikYeri + "','" + hekim + "','" + saat + "')";
                cmd = new SqlCommand(ekle, con);
                cmd.ExecuteNonQuery();
                Response.Write("Randevu Eklendi");
                Response.Redirect("HastaBilgileri.aspx");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

        }

        protected void ddlHekim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}







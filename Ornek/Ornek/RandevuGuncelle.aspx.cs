﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Ornek
{
    public partial class RandevuGuncelle : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=MERVE;initial Catalog=HTS;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void randevu_guncelle_Click(object sender, EventArgs e)
        {
            Response.Redirect("RandevuAl.aspx");

        }
    }
}
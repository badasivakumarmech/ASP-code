using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace GridViewSamples
{
    public partial class Sample9 : System.Web.UI.Page
    {
        SqlConnection Con;
        SqlDataAdapter Da;
        DataSet Ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            String Sqlcon = "Server=DESKTOP-GSHFQL4;User Id=muni;Password=muni123;Database=mkdb";
            Con = new SqlConnection(Sqlcon);
            GetData();
        }

        private void GetData()
        {
            Da = new SqlDataAdapter("Select * From EmpDetails", Con);
            Ds = new DataSet();
            Da.Fill(Ds, "Emp");
            GridView1.DataSource = Ds.Tables[0];
            GridView1.DataBind();
        }
    }
}
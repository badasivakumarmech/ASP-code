using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DataList
{
    public partial class Example6 : System.Web.UI.Page
    {
        SqlConnection Con;
        SqlDataAdapter Da;
        DataSet Ds;
        SqlCommand Cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            string sqlconString = "server=DESKTOP-GSHFQL4;user Id=muni;password=muni123;database=mkdb";
            Con = new SqlConnection(sqlconString);
            if (!Page.IsPostBack)
                GetData();       
        }

        private void GetData()
        {
            Da = new SqlDataAdapter("select * from EmpDetails", Con);
            Ds = new DataSet();
            Da.Fill(Ds, "Emp");
            DataList1.DataSource = Ds.Tables[0];
            DataList1.DataBind();
        }

    }
}
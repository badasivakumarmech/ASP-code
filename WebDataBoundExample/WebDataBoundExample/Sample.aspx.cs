using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace WebDataBoundExample
{
    public partial class Sample : System.Web.UI.Page
    {
        SqlConnection Con;DataSet Ds;
        SqlDataAdapter Da;

        protected void Page_Load(object sender, EventArgs e)
        {
            String SqlConString = "Server=DESKTOP-GSHFQL4; Integrated Security=SSPI; Database=master";
            Con = new SqlConnection(SqlConString);
            Da = new SqlDataAdapter("select * from EmpDetails", Con);
            Ds = new DataSet();
            Da.Fill(Ds, "Emp");
            Repeater1.DataSource = Ds.Tables[0];
            Repeater1.DataBind();
        }
    }
}
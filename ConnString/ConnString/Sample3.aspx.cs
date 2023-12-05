using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ConnString
{
    public partial class Sample3 : System.Web.UI.Page
    {
        SqlConnection Con; SqlCommand Cmd; SqlDataAdapter Da; DataSet Ds;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings Cs = new ConnectionStringSettings();
            Cs = ConfigurationManager.ConnectionStrings["ConString"];
            Con = new SqlConnection(Cs.ConnectionString);
            Da = new SqlDataAdapter("select * from EmpDetails", Con);
            Ds = new DataSet();
            Da.Fill(Ds,"Emp");
            GridView1.DataSource = Ds.Tables[0];
            GridView1.DataBind();

        }
    }
}
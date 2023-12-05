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
    public partial class sample2 : System.Web.UI.Page
    {
        SqlConnection Con;
        DataSet Ds;
        SqlDataAdapter Da;

        protected void Page_Load(object sender, EventArgs e)
        {
            String siva = "Server=;Integrated Security=SSPI;Database=mkdb";
            Con = new SqlConnection(siva);
            Da = new SqlDataAdapter("Selet * from DesignEmp", Con);
            Ds = new DataSet();
            Da.Fill(Ds, "Emp");
            DataList1.DataSource = Ds.Tables[0];
            DataList1.DataBind();

        }
    }
}
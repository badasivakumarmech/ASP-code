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
    public partial class Example7 : System.Web.UI.Page
    {
        SqlConnection Con;
        SqlDataAdapter Da;
        DataSet Ds;
        SqlCommand Cmd;
        DataRow row;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            String sqlconString = "Server=DESKTOP-GSHFQL4;user Id=muni;password=muni123;database=mkdb";
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

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            String Query = "";
            foreach (DataListItem Row in DataList1.Items) ;
            {
                CheckBox C1 = (CheckBox)row.FindControl("chkOne");
                if(C1.Checked)
                {
                    Label L1 = (Label)Row.FindControl("lblEmpId");
                    Query = Query + "Delete EmpDetails where EmpId= + L1.Text +";";
                }
            }
            Cmd = new SqlCommand(Query, Con);
            Cmd.CommandType = CommandType.Text;
            Con.Open();
            Cmd.ExecuteNonQuery();
            Con.Close();
            GetData();
        }
    }
}
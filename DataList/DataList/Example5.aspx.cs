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
    public partial class Example5 : System.Web.UI.Page
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

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {

            String EmpId, EName, Designation, DOJ, Salary, DeptNo;
            TextBox T1 = (TextBox)e.Item.FindControl("txtEmpId");
            EmpId = T1.Text;
            T1 = (TextBox)e.Item.FindControl("txtEName");
            EName = T1.Text;
            T1 = (TextBox)e.Item.FindControl("txtDesignation");
            Designation = T1.Text;
            T1 = (TextBox)e.Item.FindControl("txtDOJ");
            DOJ = T1.Text;
            T1 = (TextBox)e.Item.FindControl("txtSalary");
            Salary = T1.Text;
            T1 = (TextBox)e.Item.FindControl("txtDeptNo");
            DeptNo = T1.Text;

            String Query = "Insert into EmpDetails Values(@P1,@P2,@P3,@P4,@P5,@P6)";
            Cmd = new SqlCommand(Query,Con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@P1", EmpId);
            Cmd.Parameters.AddWithValue("@P2", EName);
            Cmd.Parameters.AddWithValue("@P3", Designation);
            Cmd.Parameters.AddWithValue("@P4", DOJ);
            Cmd.Parameters.AddWithValue("@P5", Salary);
            Cmd.Parameters.AddWithValue("@P6", DeptNo);

            Con.Open();
            Cmd.ExecuteNonQuery();
            Con.Close();
            GetData();
        }
    }
}
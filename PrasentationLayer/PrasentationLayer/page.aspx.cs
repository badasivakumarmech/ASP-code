using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using BusinessObject;
using System.Data;

namespace PrasentationLayer
{
    public partial class page : System.Web.UI.Page
    {
        
        BusinessLogicLayer.Employee2 BussinesEmp = new BusinessLogicLayer.Employee2();
        BusinessObject.Employee BOEmp = new BusinessObject.Employee();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                FillData();
            }

        }
        private void FillData()
        {
            DataSet ds = BussinesEmp.getEmps();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            BOEmp.Eno = int.Parse(txtempno.Text);
            BOEmp.Ename = txtempname.Text;
            BOEmp.Salary = double.Parse(txtempsal.Text);
            int i = BussinesEmp.saveEmp(BOEmp);
            if(i==1)
            {
                FillData();
            }
            else
            {
                Response.Write("Failed");
            }

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs E)
        {
            GridViewRow row = GridView1.Rows[E.RowIndex];
            Label l1 = (Label)row.FindControl("Label1");
            BOEmp.Eno = int.Parse(l1.Text);
            int i = BussinesEmp.DeleteEmp(BOEmp);
            if(i==1)
            {
                FillData();
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs E)
        {
            GridView1.EditIndex = E.NewEditIndex;
            FillData();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs E)
        {
            GridViewRow row = GridView1.Rows[E.RowIndex];
            TextBox t1 = (TextBox)row.FindControl("TextBox1");
            TextBox t2 = (TextBox)row.FindControl("TextBox2");
            TextBox t3 = (TextBox)row.FindControl("TextBox3");
            BOEmp.Eno = int.Parse(t1.Text); 
            BOEmp.Ename = t2.Text;
            BOEmp.Salary = double.Parse(t3.Text);
            int i= BussinesEmp.UpdateEmp(BOEmp);
            if(i==1)
            {
                GridView1.EditIndex = -1;
                FillData();
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs E)
        {
            GridView1.EditIndex = -1;
            FillData();
        }
    }
}
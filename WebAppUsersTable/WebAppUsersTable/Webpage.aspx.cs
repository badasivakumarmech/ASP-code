using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinesObject;
using BussinerLayer;
using System.Data;
namespace WebAppUsersTable
{
    public partial class Webpage : System.Web.UI.Page
    {
        BussinesObject.UsersDataAssa BOData = new BussinesObject.UsersDataAssa();
        BussinerLayer.BussinesDataClass BussinData = new BussinerLayer.BussinesDataClass();
        public void FillUsers()
        {
            DataSet ds = BussinData.DataGet();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                FillUsers();
            }
        }
        protected void btnUserInsert_Click(object sender, EventArgs e)
        {
            BOData.Username = txtUname.Text;
            BOData.password = txtPassword.Text;
            BOData.Firstname = txtFname.Text;
            BOData.Lastname = txtLname.Text;
            BOData.HintQUestion = txtHintQ.Text;
            BOData.HintAnswer = txtHintA.Text;
            int i = BussinData.installed(BOData);
            if(i==1)
            {
                //filldata();
                lblDiplay.Text = "***Successfull Fill the data***";
            }
            else
            {
                lblDiplay.Text = "***Failed Fill the data***";
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            Label l1 = (Label)row.FindControl("label1");
            BOData.Username = l1.Text;
            int i= BussinData.Deleted(BOData);
            if(i==1)
            {
                FillUsers();
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            FillUsers();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            TextBox t1 = (TextBox)row.FindControl("txt1");
            TextBox t2 = (TextBox)row.FindControl("txt2");
            TextBox t3 = (TextBox)row.FindControl("txt3");
            TextBox t4 = (TextBox)row.FindControl("txt4");
            TextBox t5 = (TextBox)row.FindControl("txt5");
            TextBox t6 = (TextBox)row.FindControl("txt6");
            BOData.Username = t1.Text;
            BOData.password = t2.Text;
            BOData.Firstname = t3.Text;
            BOData.Lastname = t4.Text;
            BOData.HintQUestion = t5.Text;
            BOData.HintAnswer= t6.Text;
            int i = BussinData.Update(BOData);
            if(i==1)
            {
                GridView1.EditIndex = -1;
                FillUsers();
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            FillUsers();
        }
    }
}
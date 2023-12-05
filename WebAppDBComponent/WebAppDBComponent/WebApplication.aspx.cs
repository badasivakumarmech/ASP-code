using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CLibDBOperations;

namespace WebAppDBComponent
{
    public partial class WebApplication : System.Web.UI.Page
    {
        EmpDetails OjtEmp = new EmpDetails();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            OjtEmp.PEmpId = Convert.ToInt32(txtEmpId.Text);
            OjtEmp.PEName = txtEName.Text;
            OjtEmp.PDesignation = txtDesignation.Text;
            OjtEmp.PDOJ = Convert.ToDateTime(txtDOJ.Text);
            OjtEmp.PSalary = Convert.ToDouble(txtSalary.Text);
            OjtEmp.PDeptNo = Convert.ToInt32(txtDeptNo.Text);
            int i = OjtEmp.AddEmployee();
            lblDisplay.Text = i + "Record(s) Inserted";
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            OjtEmp.PEmpId = Convert.ToInt32(txtEmpId.Text);
            OjtEmp.FindEmployee();
            txtEName.Text = OjtEmp.PEName;
            txtDesignation.Text = OjtEmp.PDesignation;
            txtDOJ.Text = OjtEmp.PDOJ.ToString();
            txtSalary.Text = OjtEmp.PSalary.ToString();
            txtDeptNo.Text = OjtEmp.PDeptNo.ToString();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            OjtEmp.PEmpId = Convert.ToInt32(txtEmpId.Text);
            OjtEmp.PEName = txtEName.Text;
            OjtEmp.PDesignation = txtDesignation.Text;
            OjtEmp.PDOJ = Convert.ToDateTime(txtDOJ.Text);
            OjtEmp.PSalary = Convert.ToDouble(txtSalary.Text);
            OjtEmp.PDeptNo = Convert.ToInt32(txtDeptNo.Text);
            int i = OjtEmp.UpdateEmployee();
            lblDisplay.Text = i + "Rcord(s) Updated";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            OjtEmp.PEmpId = Convert.ToInt32(txtEmpId.Text);
            int i = OjtEmp.DeleteEmployee();
            lblDisplay.Text = i + "Record(s) Deleted";
        }
    }
}
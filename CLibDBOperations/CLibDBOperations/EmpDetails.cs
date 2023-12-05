using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CLibDBOperations
{
    public class EmpDetails
    {
        int EmpId, DeptNo;
        String EName, Designation;
        Double Salary;
        DateTime DOJ;
        SqlCommand Cmd; SqlConnection Con; SqlDataReader DR; 
        public int PEmpId
        {
            get { return this.EmpId; }
            set { this.EmpId = value; }
        }
        public String PEName
        {
            get { return this.EName; }
            set { this.EName = value; }
        }
        public String PDesignation
        {
            get { return this.Designation; }
            set { this.Designation = value; }
        }
        public DateTime PDOJ
        {
            get { return this.DOJ; }
            set { this.DOJ = value; }
        }
        public Double PSalary
        {
            get { return this.Salary; }
            set { this.Salary = value; }
        }

        public int PDeptNo
        {
            get { return this.DeptNo; }
            set { this.DeptNo = value; }
        }
        public EmpDetails()
        {
            Con = new SqlConnection("Server=DESKTOP-GSHFQL4;User Id=muni;Password=muni123;Database=mkdb");
        }
        public int DeleteEmployee()
        {
            String Query = "Delete EmpDetails where EmpId=@p1";
            Cmd = new SqlCommand(Query, Con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@p1", this.EmpId);
            Con.Open();
            int NumRecord = Cmd.ExecuteNonQuery();
            Con.Close();
            return NumRecord;
        }
        public int AddEmployee()
        {
            String Query = "Insert Into EmpDetails values(@p1,@p2,@p3,@p4,@p5,@p6)";
            Cmd = new SqlCommand(Query, Con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@p1", this.EmpId);
            Cmd.Parameters.AddWithValue("@p2", this.EName);
            Cmd.Parameters.AddWithValue("@p3", this.Designation);
            Cmd.Parameters.AddWithValue("@p4", this.DOJ);
            Cmd.Parameters.AddWithValue("@p5", this.Salary);
            Cmd.Parameters.AddWithValue("@p6", this.DeptNo);
            Con.Open();
            int NumRecord = Cmd.ExecuteNonQuery();
            Con.Close();
            return NumRecord;
        }
        public int UpdateEmployee()
        {
            String Query = "Update EmpDetails set EName=@p1,Designation=@p2,DOJ=@p3,Salary=@p4,DeptNo=@p5 where EmpId=@p6";
            Cmd = new SqlCommand(Query, Con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@p1", this.EName);
            Cmd.Parameters.AddWithValue("@p2", this.Designation);
            Cmd.Parameters.AddWithValue("@p3", this.DOJ);
            Cmd.Parameters.AddWithValue("@p4", this.Salary);
            Cmd.Parameters.AddWithValue("@p5", this.DeptNo);
            Cmd.Parameters.AddWithValue("@p6", this.EmpId);
            Con.Open();
            int NumRecord = Cmd.ExecuteNonQuery();
            Con.Close();
            return NumRecord;
        }
        public void FindEmployee()
        {
            String Query = "Select * From EmpDetails where EmpId="this.EmpId;
            Cmd = new SqlCommand(Query, Con);
            Cmd.CommandType = CommandType.Text;
            Con.Open();
            DR = Cmd.ExecuteReader();
            if(DR.Read())
            {
                this.EName = DR[1].ToString();
                this.Designation = DR[2].ToString();
                this.DOJ = Convert.ToDateTime(DR[3]);
                this.Salary = Convert.ToDouble(DR[4]);
                this.DeptNo = Convert.ToInt32(DR[5]);
            }
            Con.Close();
        }
        

    }
}

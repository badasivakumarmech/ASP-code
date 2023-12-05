using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using BusinessObject;

namespace DataAccessLayer
{
    public class Employee1
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
        public int saveEmp(BusinessObject.Employee objempbo)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_addemp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eno", objempbo.Eno);
            cmd.Parameters.AddWithValue("@ename",objempbo.Ename);
            cmd.Parameters.AddWithValue("@sal",objempbo.Salary);
            int i=cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public int DeleteEmp (BusinessObject.Employee objempbo)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_deleteemp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eno", objempbo.Eno);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public int UpdateEmp(BusinessObject.Employee objempbo)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_updateemp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eno", objempbo.Eno);
            cmd.Parameters.AddWithValue("@ename", objempbo.Ename);
            cmd.Parameters.AddWithValue("@sal", objempbo.Salary);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public DataSet getEmps()
        {
            SqlDataAdapter da = new SqlDataAdapter("proc_getemp", con);
            DataSet ds = new DataSet();
            da.Fill(ds,"emp");
            return ds;
        }
      
    }
}

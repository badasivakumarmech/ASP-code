using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BussinesObject;

namespace DataAccesLayer
{
    public class QuaryClass
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersTable"].ToString());
        public int Inser(BussinesObject.UsersDataAssa BOUsData)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_add", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", BOUsData.Username);
            cmd.Parameters.AddWithValue("@password", BOUsData.password);
            cmd.Parameters.AddWithValue("@Firstname", BOUsData.Firstname);
            cmd.Parameters.AddWithValue("@Lastname", BOUsData.Lastname);
            cmd.Parameters.AddWithValue("@HintQUestion", BOUsData.HintQUestion);
            cmd.Parameters.AddWithValue("@HintAnswer", BOUsData.HintAnswer);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public DataSet GetData()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("proc_get", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Users");
            return ds;
        }
        public int Delete(BussinesObject.UsersDataAssa BOUsData)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", BOUsData.Username);
            int i= cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public int Update(BussinesObject.UsersDataAssa BOUsData)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@password", BOUsData.password);
            cmd.Parameters.AddWithValue("@Firstname", BOUsData.Firstname);
            cmd.Parameters.AddWithValue("@Lastname", BOUsData.Lastname);
            cmd.Parameters.AddWithValue("@HintQUestion", BOUsData.HintQUestion);
            cmd.Parameters.AddWithValue("@HintAnswer", BOUsData.HintAnswer);
            cmd.Parameters.AddWithValue("@Username", BOUsData.Username);
            int i = cmd.ExecuteNonQuery();
            return i;
        }
    }
}

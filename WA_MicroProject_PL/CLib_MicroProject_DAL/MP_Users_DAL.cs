using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CLib_MicroProject_CDL;

namespace CLib_MicroProject_DAL
{
    public class MP_Users_DAL
    {
        SqlConnection Con; SqlCommand Cmd;
        public MP_Users_DAL()
        {
            Con = new SqlConnection(GlobalData.Con);
        }
    }
}

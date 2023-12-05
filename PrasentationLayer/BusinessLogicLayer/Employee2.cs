using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccessLayer;
using System.Data;

namespace BusinessLogicLayer
{
    public class Employee2
    {
        DataAccessLayer.Employee1 objempdal = new DataAccessLayer.Employee1();
        public int saveEmp(BusinessObject.Employee objempbo)
        {
            int i = objempdal.saveEmp(objempbo);
            return i;
        }
        public int DeleteEmp(BusinessObject.Employee objempbo)
        {
            int i = objempdal.DeleteEmp(objempbo);
            return i;
        }
        public int UpdateEmp(BusinessObject.Employee objempbo)
        {
            int i = objempdal.UpdateEmp(objempbo);
            return i;
        }
        public DataSet getEmps()
        {
            DataSet ds = objempdal.getEmps();
            return ds;
        }
    }
}

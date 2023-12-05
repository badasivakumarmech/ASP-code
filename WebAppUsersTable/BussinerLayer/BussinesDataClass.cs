using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using BussinesObject;
using System.Data;

namespace BussinerLayer
{
    
    public class BussinesDataClass
    {
        DataAccesLayer.QuaryClass BussClass = new DataAccesLayer.QuaryClass();
        public int installed(BussinesObject.UsersDataAssa UseAcces)
        {
            int i = BussClass.Inser(UseAcces);
            return i;
        }
       public DataSet DataGet()
        {
            DataSet ds= BussClass.GetData();
            return ds;
        }
        public int Deleted(BussinesObject.UsersDataAssa UseAcce)
        {
            int i = BussClass.Delete(UseAcce);
            return i;
        }
        public int Update(BussinesObject.UsersDataAssa UseAcce)
        {
            int i = BussClass.Delete(UseAcce);
            return i;
        }

    }
}

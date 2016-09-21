using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
  public  class LoginDal : DataAccess
    {
        DataTable dt;
        

      // This method to get the user details for the given login details
        public DataTable getLogin(String uname ,String password)
        {
            try
            {
                string sql = "";
                DataSet dt;
                sql = "SELECT   *   FROM         CIA_User where Username= '" + uname + "' and  Password ='" + password + "'";
                dt = getDataset(sql);
                return dt.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace DAL
{
    public class TaskDal : DataAccess
    {

        public DataTable GetAllDataForUser(String user)
        {
            try
            {
                string sql = "";
                DataSet dt;



                sql = "SELECT        Sender, Message, ReceivedDate FROM    FB_MessageReceived";
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

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace DAO
{
    public class PendingOrder:DataAccess
    {
        public List<OrderDetails> GetAllPendingOrer()
        {
            List<OrderDetails> _lst = new List<OrderDetails>();
            string sql = "select * from  view_pendingOrder";
            SqlDataReader dr = getDataReaderData(sql);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    _lst.Add(new OrderDetails
                    {
                        customerName = dr["Sender"] != DBNull.Value ? Convert.ToString(dr["Sender"]) : "",
                        receivedDate = dr["ReceivedDate"] != DBNull.Value ? Convert.ToDateTime(dr["ReceivedDate"]) : DateTime.Now,
                        orderId = dr["ID"] != DBNull.Value ? Convert.ToString(dr["ID"]) : "",
                    });
                }
            }
            
            return _lst;
        }
    }
}

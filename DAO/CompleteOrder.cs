using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;

namespace DAO
{
   public class CompleteOrder:DataAccess
    {
       public List<OrderSummary> GetAllCompletOrder()
       {
           List<OrderSummary> _lst = new List<OrderSummary>();
           string sql = "select * from  view_completOrder";
           SqlDataReader dr = getDataReaderData(sql);

           if (dr.HasRows)
           {
               while (dr.Read())
               {
                   _lst.Add(new OrderSummary
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

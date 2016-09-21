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
            string sql = "SELECT O_id, Qty, UnitPrice, Value, ItemCode FROM FB_Order_Details";
            SqlDataReader dr = getDataReaderData(sql);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    _lst.Add(new OrderDetails
                    {
                        itemCode = dr["ItemCode"] != DBNull.Value ? Convert.ToString(dr["ItemCode"]) : ""
                    });
                }
            }
            
            return _lst;
        }
    }
}

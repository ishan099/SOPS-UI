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
    public class PendingOrder : DataAccess
    {

        //get pending order summary
        public List<OrderSummary> GetAllPendingOrder()
        {
            List<OrderSummary> _lst = new List<OrderSummary>();
            string sql = "select * from  view_pendingOrder";
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

        //get current order summary details
        public List<CurrentOrderDetails> GetCurrentPendingOrder(string orderId)
        {
            List<OrderDetails> _lstOrder = new List<OrderDetails>();
            List<OrderSummary> _lstCustomer = new List<OrderSummary>();
            List<CurrentOrderDetails> _lstCurrentOrder= new List<CurrentOrderDetails>();

            string sql = "SELECT  DISTINCT dbo.FB_MessageReceived.ID, dbo.FB_MessageReceived.Sender," +
                "dbo.FB_MessageReceived.ReceivedDate, dbo.FB_Order_Details.ItemCode, dbo.FB_Order_Details.Qty," +
                "dbo.FB_Order_Details.UnitPrice,dbo.FB_Order_Details.Value, dbo.CIA_ItemMaster.ItemName FROM " +
                " dbo.FB_MessageReceived INNER JOIN dbo.FB_Order_Details ON " +
                "dbo.FB_MessageReceived.ID = dbo.FB_Order_Details.O_id INNER JOIN " +
                 "dbo.CIA_ItemMaster ON dbo.FB_Order_Details.ItemCode = dbo.CIA_ItemMaster.ItemCode " +
                 "where FB_MessageReceived.ID ='" + Convert.ToInt16(orderId) + "'";
            SqlDataReader dr = getDataReaderData(sql);

            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    if (i == 0)
                    {
                        _lstCustomer.Add(new OrderSummary
                        {
                            customerName = dr["Sender"] != DBNull.Value ? Convert.ToString(dr["Sender"]) : "",
                            receivedDate = dr["ReceivedDate"] != DBNull.Value ? Convert.ToDateTime(dr["ReceivedDate"]) : DateTime.Now,
                            orderId = dr["ID"] != DBNull.Value ? Convert.ToString(dr["ID"]) : "",
                        });
                    }

                    _lstOrder.Add(new OrderDetails
                    {
                        itemCode = dr["ItemCode"] != DBNull.Value ? Convert.ToString(dr["ItemCode"]) : "-",
                        itemName = dr["ItemName"] != DBNull.Value ? Convert.ToString(dr["ItemName"]) : "-",
                        qty = dr["Qty"] != DBNull.Value ? Convert.ToString(dr["Qty"]) : "0",
                        unitPrice = dr["UnitPrice"] != DBNull.Value ? Convert.ToDecimal(dr["UnitPrice"]) : 0,
                        value = dr["Value"] != DBNull.Value ? Convert.ToDecimal(dr["Value"]) : 0,

                    });
                    i++;
                }
                _lstCurrentOrder.Add(new CurrentOrderDetails
                {
                    customer = _lstCustomer,
                    currentOrder = _lstOrder
                });
            }

            return _lstCurrentOrder;
        }

        //update order status 

        public bool UpdateOrderStatus(string orderId,string status)
        {
            string sql = "update FB_MessageReceived  SET  FB_MessageReceived.Status='" + status + "' where  FB_MessageReceived.ID='" + Convert.ToInt16(orderId) + "'";
            int state = exeNonQury(sql);
            return state == 1 ? true : false;

        }

    }
}

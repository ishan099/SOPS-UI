using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class OrderDetails
    {
       public string qty { get; set; }
       public decimal unitPrice { get; set; }
       public decimal value { get; set; }
       public float total { get; set; }
       public string itemName { get; set; }
       public string itemCode { get; set; }

    }

   public class OrderSummary
   {
       public string customerName { get; set; }
       public string orderId { get; set; }
       public DateTime receivedDate { get; set; }
   }

   public class CurrentOrderDetails
   {
       public List<OrderSummary> customer { get; set; }
       public List<OrderDetails> currentOrder { get; set; }


   }

}

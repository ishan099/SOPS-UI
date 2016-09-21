using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class OrderDetails
    {
       public string customerName { get; set; }
       public string orderId { get; set; }
       public string qty { get; set; }
       public float unitPrice { get; set; }
       public float total { get; set; }
       public string itemName { get; set; }
       public string itemCode { get; set; }


    }
}

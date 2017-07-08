using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Billing.Entity
{
    class BillingDelivertDetailEL
    {

         public int Purchases_Order_Id {get; set;}
         public int Purchase_Order_Detail_Id {get; set;}
		 public int Item_Quantity  {get; set;}		
         public int Delivery_Id  {get; set;}
         public string Delivery_No { get; set; }
         public DateTime Delivery_Date { get; set; }
         public int Delivery_Detail_Id {get; set;}
		 public int Deliver_Quantity {get; set;}
         public int Total_Deliver_Quantity {get; set;}
		 public int Challan_Billing_Quantity {get; set;}
         public string Purchases_Order_No { get; set; }
         public DateTime PURCHASES_ORDER_Date { get; set; }
    }
}

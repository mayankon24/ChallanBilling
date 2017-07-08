using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Billing.Entity
{
    class DeliveryDetailEL
    {
        public int Delivery_Detail_Id { get; set; }
        public int Delivery_Id { get; set; }
        public int Purchases_Order_Id { get; set; }
        public int Purchase_Order_Detail_Id { get; set; }
        public double Deliver_Quantity { get; set; }       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Billing.Entity
{
    class DeliveryEL
    {
        public int Delivery_Id { get; set; }
        public int company_id { get; set; }
        public int Purchases_Order_Id { get; set; }
        public string Delivery_no { get; set; }
        public DateTime Delivery_Date { get; set; }       
    }
}

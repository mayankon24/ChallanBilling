using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Billing.Entity
{
    class BillDetailEL
    {
        public int Bill_Detail_Id { get; set; }
        public int Bill_Item_Id { get; set; }
        public int Delivery_Detail_Id { get; set; }
        public double Quantity { get; set; }
        //public int Form { get; set; }
        //public decimal Rate { get; set; }
        //public int Color { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Billing.Entity
{
   public class BillItemEL
    {
        public int Bill_Item_Id { get; set; }
        public int Bill_Id { get; set; }
        public int? Purchase_Order_Detail_Id { get; set; }
        public string Item_Name { get; set; }
        public int? Item_Id { get; set; }
        public double Quantity { get; set; }
        public decimal Form { get; set; }
        public decimal Rate { get; set; }
        public int Color { get; set; }
        public int? Parent_Id { get; set; }

        public BillItemEL()
        {
            Purchase_Order_Detail_Id = null;
            Item_Name = null;
            Parent_Id = null;
        }
    }
}

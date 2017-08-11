using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Billing.Entity
{
   public class BillEL
    {
        public int Bill_Id { get; set; }
        public int Company_id { get; set; }
        public string Bill_No { get; set; }
        public int Bill_Type_Id { get; set; }
        public DateTime Bill_Date { get; set; }
        public string Tax_Name { get; set; }
        public string Central_Tax_Name { get; set; }
        public decimal? Tax_Percentage { get; set; }
        public decimal? Central_Tax_Percentage { get; set; }
        public int Is_Tax_Inclusive { get; set; }
        public decimal? Cartage { get; set; }
        public decimal? Discount { get; set; }

        public BillEL()
        {
            Cartage = null;
            Discount = null;
        }

    }
}

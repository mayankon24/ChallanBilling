using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Billing.Entity
{
    public class BillItemNarrationEL
    {
        public int BillItem_Narration_Id { get; set; }
        public int Bill_Item_Id { get; set; }
        public string Narration { get; set; }
    }
}

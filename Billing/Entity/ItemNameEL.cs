using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Billing.Entity
{
    [Serializable]

    public class ItemNameEL
    {
        public int Item_id { get; set; }
        public string Item_name { get; set; }
        public string Item_name_description { get; set; }
        public decimal Item_Price { get; set; }
        public int Company_Id { get; set; }
        public int Company_Item_Id { get; set; }
    }
}

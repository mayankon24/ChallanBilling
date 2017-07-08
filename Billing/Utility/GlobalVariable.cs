using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Billing.Utility
{
    public class metaDataConfig
    {
        static public int totalMetaDataSize
        {
            get
            {
                return 22;
            }
        }
        static public int endAddressSize
        {
            get
            {
                return 4;
            }
        }
        static public int serialNumberSize
        {
            get
            {
                return 16;
            }
        }
        static public int templateIdSize
        {
            get
            {
                return 2;
            }
        }
    }
    public class GlobalVariable
    {
        public static string SheetName = "GuestFields$";
    }
}

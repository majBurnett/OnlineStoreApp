using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreClassLibrary
{
    public class InventorySummary : OnlineStore
    {
        public InventorySummary()
        {
            productsList = new List<ProductsPurchaseOrder>();
        }

        public InventorySummary(List<ProductsPurchaseOrder> list)
        {
            productsList = list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreClassLibrary
{
    public interface IOnlineStore
    {
        void AddProductsToInventory(ProductsPurchaseOrder purchaseOrder);
        ProductsSoldResult SellProductsFromInventory(ProductsSellOrder itemsSoldOrder);
        InventoryItemSummary GetInventoryItemSummary(ProductType stockType);
        InventorySummary GetInventorySummary();
    }
}

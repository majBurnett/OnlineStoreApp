using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreClassLibrary
{
    public class InventoryItemSummary : OnlineStore
    {

        public InventoryItemSummary()
        {
            shoppingList = new List<ProductsPurchaseOrder>();
        }

        public InventoryItemSummary(List<ProductsPurchaseOrder> _shoppingList)
        {
            shoppingList = _shoppingList;
        }


        public int getAmountofProducts()
        {
            int totalAmount = 0;
            foreach (ProductsPurchaseOrder tp in shoppingList)
            {
                totalAmount = totalAmount + tp.Amount;
            }
            return totalAmount;
        }

        public decimal getAvgPrice()
        {
            int amount = getAmountofProducts();
            decimal totalCost = 0;
            foreach (ProductsPurchaseOrder pt in shoppingList)
            {
                totalCost = totalCost + pt.Price;
            }
            totalCost = totalCost / amount;
            return totalCost;

            //foreach (ProductsPurchaseOrder pt in product)
            //{
            //    avg = avg + pt.Amount;
            //}
            //avg = totalCost / avg;
        }
    }
}

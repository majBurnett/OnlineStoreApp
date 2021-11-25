using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreClassLibrary
{
    public class OnlineStore : IOnlineStore
    {

        public List<ProductsPurchaseOrder> productsList { get; set; }
        public List<ProductsPurchaseOrder> shoppingList { get; set; }
        public List<ProductsPurchaseOrder> soldList { get; set; }


        public OnlineStore()
        {
            productsList = new List<ProductsPurchaseOrder>();
            shoppingList = new List<ProductsPurchaseOrder>();
            soldList = new List<ProductsPurchaseOrder>();
        }

        //Add products to List
        public void AddProductsToInventory(ProductsPurchaseOrder purchaseOrder)
        {
            for (int i = 0; i < purchaseOrder.Amount; i++)
            {
                productsList.Add(purchaseOrder);
            }            
        }
        //Removing from Inventory
        public ProductsSoldResult SellProductsFromInventory(ProductsSellOrder itemsSoldOrder)
        {
            for (int i = itemsSoldOrder.Amount - 1; i >= 0; i--)
            {
                if (productsList[i].Type == itemsSoldOrder.Type)
                {
                    productsList.RemoveAt(i);
                }
            }
            return new ProductsSoldResult(soldList = productsList.Where(x => x.Type == itemsSoldOrder.Type && x.Model == itemsSoldOrder.Model).ToList());
        }
        //Display specific product in Stock
        public InventoryItemSummary GetInventoryItemSummary(ProductType stockType)
        {
            return new InventoryItemSummary(shoppingList = productsList.Where(x => x.Type == stockType.Type && x.Model == stockType.Model).ToList());
        }
        //View all products in Stock
        public InventorySummary GetInventorySummary()
        {
            return new InventorySummary(productsList);
        }
    }
}

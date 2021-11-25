using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreClassLibrary
{
    public class ProductsSoldResult : OnlineStore
    {
        //public List<ProductsPurchaseOrder> shoppingList { get; set; }
        //public int amountSold { get; set; }
        public ProductsSoldResult()
        {
            soldList = new List<ProductsPurchaseOrder>();
            //amountSold = 0;
        }
        public ProductsSoldResult(List<ProductsPurchaseOrder> _soldList)
        {
            soldList = _soldList;
            //amountSold = _amountSold;
        }
    }
}

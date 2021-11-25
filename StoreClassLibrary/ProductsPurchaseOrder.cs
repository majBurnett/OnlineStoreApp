using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreClassLibrary
{
    public class ProductsPurchaseOrder : ProductType
    {
        public decimal Price { get; set; }
        public int Amount { get; set; }

        public ProductsPurchaseOrder()
        {
            Type = "Nothing";
            Model = "Nothing";
            Price = 0.00M;
            Amount = 0;
        }

        public ProductsPurchaseOrder(string _type, string _model, decimal _price, int _amount)
        {
            Type = _type;
            Model = _model;
            Price = _price;
            Amount = _amount;
        }

        public override string ToString()
        {
            return "Type: " + Type + " Model: " + Model + " Price: R" + Price;
        }
    }
}

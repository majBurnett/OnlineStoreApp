using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreClassLibrary
{
    public class ProductsSellOrder : ProductsPurchaseOrder
    {
        public ProductsSellOrder()
        {
            Type = "";
            Amount = 0;
        }
        public ProductsSellOrder(string _type, string _model, int _amount)
        {
            Type = _type;
            Model = _model;
            Amount = _amount;
        }
    }
}

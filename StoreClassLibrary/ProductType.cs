using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreClassLibrary
{
    public class ProductType
    {
        public string Type { get; set; }
        public string Model { get; set; }

        public ProductType()
        {
            Type = "Nothing";
            Model = "Nothing";
        }
        public ProductType(string _type, string _Model)
        {
            Type = _type;
            Model = _Model;
        }
    }
}

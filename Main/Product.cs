using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Product
    {
        public string ProductID { get; set; }        
        public string ProductName { get; set; }
        public string Category { get; set; }
        public Product(string productID, string productName, string category )
        {
            this.ProductID = productID;
            this.ProductName = productName;
            this.Category = category;
        }
    }
}

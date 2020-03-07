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
        public override string ToString()
        {
            return string.Format($"{ProductID} | {ProductName} | {Category}");
        }
        public override bool Equals(object obj)
        {
            var that = (Product)obj;
            return this.ProductID.Equals(that.ProductID,StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return ProductID.GetHashCode();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class SaleDetail
    {
        public Guid ID { get; private set; }
        public string SaleID { get; set; }
        public string ProductID { get; set; }
        public int Quantity { get; set; }

        public SaleDetail(string saleID, string productID, int quantity)
        {
            this.ID = new Guid();
            this.SaleID = saleID;
            this.ProductID = productID;
            this.Quantity = quantity;
        }
        public override bool Equals(object obj)
        {
            var that = (SaleDetail)obj;
            return this.ID.Equals(that.ID);
        }

        public override int GetHashCode()
        {
            return this.ID.GetHashCode();
        }
    }
}

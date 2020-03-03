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
        public string Quantity { get; set; }

        public SaleDetail(string saleID, string productID, string quantity)
        {
            this.ID = new Guid();
            this.SaleID = saleID;
            this.ProductID = productID;
            this.Quantity = quantity;
        }
    }
}

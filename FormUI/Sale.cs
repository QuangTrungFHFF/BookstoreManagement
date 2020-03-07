using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Sale
    {
        public string SaleID { get; private set; }
        public string SaleDate { get; set; }
        public string EmployeeID { get; set; }
        public string CustomerID { get; set; }
        public Sale(string saleID, string saleDate, string customerID, string employeeID)
        {
            this.SaleID = saleID;
            this.SaleDate = saleDate;
            this.EmployeeID = employeeID;
            this.CustomerID = customerID;
        }

        public override bool Equals(object obj)
        {
            var that = (Sale)obj;
            return this.SaleID.Equals(that.SaleID,StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return this.SaleID.GetHashCode();
        }
    }
}

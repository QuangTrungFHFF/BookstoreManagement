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
        public Sale(string saleDate, string customerID, string employeeID)
        {
            this.SaleDate = saleDate;
            this.EmployeeID = employeeID;
            this.CustomerID = customerID;
        }
    }
}

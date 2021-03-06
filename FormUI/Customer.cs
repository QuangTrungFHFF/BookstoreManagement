﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Customer
    {
        public string CustomerID { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string JobTitle { get; private set; }
        public string BussinessPhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string MemberType { get; set; }

        public Customer(string customerID, string customerFirstName, string customerLastName,
            string jobTitle, string bussinessPhoneNumber, 
            string address, string city, string memberType)
        {
            this.CustomerID = customerID;
            this.CustomerFirstName = customerFirstName;
            this.CustomerLastName = customerLastName;
            this.JobTitle = jobTitle;
            this.BussinessPhoneNumber = bussinessPhoneNumber;
            this.Address = address;
            this.City = city;
            this.MemberType = memberType;
        }

        public string GetCustomerName()
        {
            return string.Format($"{CustomerID}: {this.CustomerFirstName} {this.CustomerLastName}");
        }

        public override string ToString()
        {
            var info = new StringBuilder();
            info.Append($"Customer ID: {CustomerID}");
            info.Append(Environment.NewLine);
            info.Append($"Customer name: {this.GetCustomerName()}");
            info.Append(Environment.NewLine);
            info.Append($"Job Title: {JobTitle}");
            info.Append(Environment.NewLine);
            info.Append($"Phone number: {BussinessPhoneNumber}");
            info.Append(Environment.NewLine);
            info.Append($"Address: {Address}, {City}");
            info.Append(Environment.NewLine);
            info.Append($"Member Type: {MemberType}");
            return info.ToString();
        }
        public override bool Equals(object obj)
        {
            var that = (Customer)obj;
            return this.CustomerID.Equals(that.CustomerID,StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return this.CustomerID.GetHashCode();
        }
    }
}

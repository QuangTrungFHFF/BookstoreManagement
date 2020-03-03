using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Employee
    {
        public string EmployeeID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; private set; }
        public string JobTitle { get; private set; }
        public string Branch {get; set;}
        public string Department { get; set; }
        public string BussinessPhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Nationality { get; set; }

        public Employee(string employeeID, string employeeFirstName, string employeeLastName,
            string username, string password, string jobTitle, string branch, string department,
            string bussinessPhoneNumber, string homePhoneNumber, string address,
            string city, string nationality)
        {
            this.EmployeeID = employeeID;
            this.EmployeeFirstName = employeeFirstName;
            this.EmployeeLastName = employeeLastName;
            this.UserName = username;
            this.Password = password;
            this.JobTitle = jobTitle;
            this.Branch = branch;
            this.Department = department;
            this.BussinessPhoneNumber = bussinessPhoneNumber;
            this.HomePhoneNumber = homePhoneNumber;
            this.Address = address;
            this.City = city;
            this.Nationality = nationality;
        }


    }
}

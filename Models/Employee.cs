// Models/Employee.cs
using System;
using EmployeeManagementSystem.Models;
namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public DateTime JoinDate { get; set; }
        public string PhoneNumber { get; set; }

        // Foreign key property
        public int DepartmentID { get; set; }

        // Navigation property
        public Department Department { get; set; }
    }
}

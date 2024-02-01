// Models/Department.cs
namespace EmployeeManagementSystem.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public List<Employee> Employee { get; set; }
    }
}

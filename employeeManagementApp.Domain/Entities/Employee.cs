using System;
using System.ComponentModel.DataAnnotations;

namespace employeeManagementApp.Domain.Entities
{
    public  class Employee
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public int Salary { get; set; }
        [Key]
        [Required]
        public int? EmployeeId { get; set; }
        public string AvailableHours { get; set; }
       // public int salaryType { get; set; }
    }
}

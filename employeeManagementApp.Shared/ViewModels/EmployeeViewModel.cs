﻿using System;
using employeeManagementApp.Shared.Enums;

namespace employeeManagementApp.Shared.ViewModels
{
    public  class EmployeeViewModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public int Salary { get; set; }
        public int? EmployeeId { get; set; }
        public string AvailableHours { get; set; }
        public string FullName { get; set; }
       // public SalaryTypeEnum SalaryType { get; set; }
       // public string SalaryTypeName => SalaryType.ToString();
    }
}

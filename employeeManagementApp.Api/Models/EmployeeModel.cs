﻿using System;

namespace employeeManagementApp.Api.Models
{
    public class EmployeeModel
    {
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get; set; }
        public DateTime hireDate { get; set; }
        public string department { get; set; }
        public string jobTitle { get; set; }
        public int salary { get; set; }
        public int employeeId { get; set; }
        public string availableHours { get; set; }
        public enum SalaryType
        {
            hourly,
            salary
        }
    }
}
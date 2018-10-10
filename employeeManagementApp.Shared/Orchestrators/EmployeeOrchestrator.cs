using employeeManagementApp.Domain;
using employeeManagementApp.Shared.Orchestrators.Interfaces;
using employeeManagementApp.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeManagementApp.Shared.Orchestrators
{
   public class EmployeeOrchestrator : IEmployeeOrchestrator
    {
        public EmployeeContext _employeeContext;
        public EmployeeOrchestrator()
        {
            _employeeContext = new EmployeeContext();
        }

            public async Task<int> CreateEmployee(EmployeeViewModel employee)
            {
                _employeeContext.Employees.Add(new Domain.Entities.Employee
                {
                    firstName = employee.firstName,
                    middleName = employee.middleName,
                    lastName = employee.lastName,
                    birthDate = employee.birthDate,
                    hireDate = employee.hireDate,
                    department = employee.department,
                    jobTitle = employee.jobTitle,
                    salary = employee.salary,
                    employeeId = employee.employeeId,
                    availableHours = employee.availableHours
                });
                return await _employeeContext.SaveChangesAsync();
            }

        

        public async Task<List<EmployeeViewModel>> GetAllEmployees()
        {
            var employees = await _employeeContext.Employees.Select(x => new EmployeeViewModel
            {
                firstName = x.firstName,
                middleName = x.middleName,
                lastName = x.lastName,
                birthDate = x.birthDate,
                hireDate = x.hireDate,
                department = x.department,
                jobTitle = x.jobTitle,
                salary = x.salary,
                employeeId = x.employeeId,
                availableHours = x.availableHours,
            }).ToListAsync();
            return employees; 
        }
    }
}

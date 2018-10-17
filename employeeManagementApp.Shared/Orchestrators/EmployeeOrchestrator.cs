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
                    FirstName = employee.FirstName,
                    MiddleName = employee.MiddleName,
                    LastName = employee.LastName,
                    BirthDate = employee.BirthDate,
                    HireDate = employee.HireDate,
                    Department = employee.Department,
                    JobTitle = employee.JobTitle,
                    Salary = employee.Salary,
                    EmployeeId = employee.EmployeeId,
                    AvailableHours = employee.AvailableHours
                });
                return await _employeeContext.SaveChangesAsync();
            }

        

        public async Task<List<EmployeeViewModel>> GetAllEmployees()
        {
            var employees = await _employeeContext.Employees.Select(x => new EmployeeViewModel
            {
                FirstName = x.FirstName,
                MiddleName = x.MiddleName,
                LastName = x.LastName,
                BirthDate = x.BirthDate,
                HireDate = x.HireDate,
                Department = x.Department,
                JobTitle = x.JobTitle,
                Salary = x.Salary,
                EmployeeId = x.EmployeeId,
                AvailableHours = x.AvailableHours,
            }).ToListAsync();
            return employees; 
        }

        public async Task<EmployeeViewModel> SearchEmployee(string searchString)
        {
            var employee = await _employeeContext.Employees
                .Where(x => x.FirstName.StartsWith(searchString))
                .FirstOrDefaultAsync();

            if (employee == null)
            {
                return  new EmployeeViewModel();
            }

            var viewModel = new EmployeeViewModel
            {
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName =  employee.LastName,
                BirthDate = employee.BirthDate,
                HireDate = employee.HireDate,
                Department = employee.Department,
                JobTitle = employee.JobTitle,
                Salary = employee.Salary,
                EmployeeId = employee.EmployeeId,
                AvailableHours = employee.AvailableHours
            };
            return viewModel;
        }

        public async Task<bool> UpdateEmployee(EmployeeViewModel employee)
        {
            var updateEntity = await _employeeContext.Employees.FindAsync(employee.EmployeeId);
            if (updateEntity == null)
            {
                return false;
            }

            updateEntity.FirstName = employee.FirstName;
            updateEntity.MiddleName = employee.MiddleName;
            updateEntity.LastName = employee.LastName;
            updateEntity.BirthDate = employee.BirthDate;
            updateEntity.HireDate = employee.HireDate;
            updateEntity.Department = employee.Department;
            updateEntity.JobTitle = employee.JobTitle;
            updateEntity.Salary = employee.Salary;
            updateEntity.AvailableHours = employee.AvailableHours;
            try
            {
            await _employeeContext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                var x = ex.ToString();
                return false;
            }
            return true;
        }
    }
}

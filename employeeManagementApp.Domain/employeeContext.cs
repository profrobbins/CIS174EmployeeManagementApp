using employeeManagementApp.Domain.Entities;
using System.Data.Entity;

namespace employeeManagementApp.Domain
{
   public class EmployeeContext:DbContext 
    {
        public DbSet<Employee> Employees { get; set; }
    }
}

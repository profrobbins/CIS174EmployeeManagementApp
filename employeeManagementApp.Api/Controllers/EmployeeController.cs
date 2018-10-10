﻿using employeeManagementApp.Shared.Orchestrators;
using employeeManagementApp.Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
namespace employeeManagementApp.Api.Controllers
{
    [Route("api/v1/Employees")]
    public class EmployeeController : ApiController 
    {
        public EmployeeOrchestrator _employeeOrchestrator;
        // private EmployeeManagerContext employeeManagerContext;

        public EmployeeController()
        {
            _employeeOrchestrator = new EmployeeOrchestrator();
        }
        public async Task<List<EmployeeViewModel>> GetAllEmployees()
        {
            var employees = await _employeeOrchestrator.GetAllEmployees();
            return employees;
        }
    }
}
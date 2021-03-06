﻿using employeeManagementApp.Shared.Orchestrators;
using employeeManagementApp.Shared.Orchestrators.Interfaces;
using employeeManagementApp.Shared.ViewModels;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
namespace employeeManagementApp.Api.Controllers
{
    [Route("api/v1/Employees")]
    public class EmployeeController : ApiController 
    {
        // public EmployeeOrchestrator _employeeOrchestrator = new EmployeeOrchestrator();
        private readonly IEmployeeOrchestrator _employeeOrchestrator;

        public EmployeeController(IEmployeeOrchestrator employeeOrchestrator)
        {
            _employeeOrchestrator = employeeOrchestrator;
        }
       /* public EmployeeOrchestrator _employeeOrchestrator;
        // private EmployeeManagerContext employeeManagerContext;

        public EmployeeController()
        {
            _employeeOrchestrator = new EmployeeOrchestrator();
        }*/
        public async Task<List<EmployeeViewModel>> GetAllEmployees()
        {
            var employees = await _employeeOrchestrator.GetAllEmployees();
            return employees;
        }

        public List<EmployeeViewModel>  GetAllEmployeeList()
        {
            var employees =  _employeeOrchestrator.GetAllEmployeeList();
            return employees;
        }
        public EmployeeViewModel GetEmployee(int employeeId)
        {
            var employee = _employeeOrchestrator.GetEmployee(employeeId);
            if(employee == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            };
            return employee;
        }
    }
}

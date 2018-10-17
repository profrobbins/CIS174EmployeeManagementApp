using System;
using employeeManagementApp.Shared.Orchestrators;
using employeeManagementApp.Shared.ViewModels;
using employeeManagementApp.web.Models;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace employeeManagementApp.web.Controllers
{
    public class EmployeeController : Controller
    {
        public EmployeeOrchestrator _employeeOrchestrator = new EmployeeOrchestrator();
        // GET: Employee
        public async Task<ActionResult> Index()
        {
            var employeeDisplayModel = new EmployeeDisplayModel
            {
                Employees = await _employeeOrchestrator.GetAllEmployees()
            };
            return View(employeeDisplayModel);
        }
        public async Task<ActionResult> CreateEmployee(CreateEmployeeModel employee)
        {
            if (string.IsNullOrWhiteSpace(employee.FirstName))
                return View();

            EmployeeViewModel employeeViewModel = new EmployeeViewModel
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
            };



            await _employeeOrchestrator.CreateEmployee(employeeViewModel);

            return View();
        }

        public ActionResult Update()
        {
            return View();
        }

        public async Task<JsonResult> UpdateEmployee(UpdateEmployeeModel employee)
        {
            if (employee.EmployeeId == null)
            return Json(false, JsonRequestBehavior.AllowGet);

            var result = await _employeeOrchestrator.UpdateEmployee(new EmployeeViewModel
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
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public async Task<JsonResult> Search(string searchString)
        {
            var viewmodel = await _employeeOrchestrator.SearchEmployee(searchString);
            return Json(viewmodel, JsonRequestBehavior.AllowGet);
        }
    }
}
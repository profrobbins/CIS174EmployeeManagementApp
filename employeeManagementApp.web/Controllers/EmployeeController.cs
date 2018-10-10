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
            if (string.IsNullOrWhiteSpace(employee.firstName))
                return View();

            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            employeeViewModel.firstName = employee.firstName;
            employeeViewModel.middleName = employee.middleName;
            employeeViewModel.lastName = employee.lastName;
            employeeViewModel.birthDate = employee.birthDate;
            employeeViewModel.hireDate = employee.hireDate;
            employeeViewModel.department = employee.department;
            employeeViewModel.jobTitle = employee.jobTitle;
            employeeViewModel.salary = employee.salary;
            employeeViewModel.employeeId = employee.employeeId;
            employeeViewModel.availableHours = employee.availableHours;



            await _employeeOrchestrator.CreateEmployee(employeeViewModel);

            return View();
        }
    }
}
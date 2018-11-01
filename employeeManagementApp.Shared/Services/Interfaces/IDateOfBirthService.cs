using employeeManagementApp.Shared.ViewModels;

namespace employeeManagementApp.Shared.Services.Interfaces
{
    interface IDateOfBirthService
    {
        bool IsTodayYourBirthday(EmployeeViewModel employee);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using employeeManagementApp.Shared.Services.Interfaces;
using employeeManagementApp.Shared.ViewModels;

namespace employeeManagementApp.Shared.Services
{
    public class DateOfBirthService : IDateOfBirthService
    {
        private readonly IDateTimeService _dateTimeService;

        public DateOfBirthService(IDateTimeService dateTimeService)
        {
            _dateTimeService = dateTimeService;
        }

        public bool IsTodayYourBirthday(EmployeeViewModel employee)
        {
                return employee.BirthDate.DayOfYear == _dateTimeService.Now().DayOfYear;
        }
    }
}

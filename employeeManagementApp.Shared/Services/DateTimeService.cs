using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using employeeManagementApp.Shared.Services.Interfaces;
using employeeManagementApp.Shared.ViewModels;

namespace employeeManagementApp.Shared.Services
{
    public class DateTimeService : IDateTimeService
    {
        private readonly IDateTimeService _dateTimeService;

        public DateTimeService(IDateTimeService dateTimeService)
        {
            _dateTimeService = dateTimeService;
        }

        public DateTime Now()
        {
            return DateTime.Now;
        }

        
    }
}

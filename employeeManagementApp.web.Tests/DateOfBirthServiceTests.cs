using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMoq;
using employeeManagementApp.Shared.Services.Interfaces;
using employeeManagementApp.Shared.ViewModels;
using employeeManagementApp.Shared.Services;

namespace employeeManagementApp.web.Tests
{
    [TestClass]
    class DateOfBirthServiceTests
    {
        private readonly AutoMoqer _mocker = new AutoMoqer();

        [TestMethod]
        public void BirthdayToday_ReturnsTrue_WhenBirthdayMatchesToday()
        {
            _mocker.GetMock<IDateTimeService>()
                .Setup(x => x.Now())
                .Returns(new DateTime(2018, 10, 31));
            var employee = new EmployeeViewModel
            {
                FirstName = "James Dean",
                BirthDate = new DateTime(2018,10,31)
            };
            var dateOfBirthService = _mocker.Create<DateOfBirthService>();
            var  isBirthday = DateOfBirthService

        }
        
    }
}

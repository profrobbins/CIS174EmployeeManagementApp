/** =========================================================

 Student First & Last Name
 James Robbins
 Operating System( Windows 10)

 Microsoft Visual Studio 2017 Community

 CIS 174

 Name Of homework Assignment(example: Unit 1 Ski Resorts)
 employee Management App
 Program Description: What the programs primary purpose is
 this program is designed to create employees, show employees using a database and the mvc
 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.

=========================================================== **/
using System.Web.Mvc;

namespace employeeManagementApp.web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}
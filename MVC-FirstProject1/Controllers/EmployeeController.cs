using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_FirstProject1.Models;

namespace MVC_FirstProject1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult EmployeeInfo()
        {
            Employee employee=new Employee()

            {
                EmployeeId=214509,
                EmployeeName="chandini",
                EmployeeLocation="bengaluru"
            };
            return View(employee);
        }
    }
}
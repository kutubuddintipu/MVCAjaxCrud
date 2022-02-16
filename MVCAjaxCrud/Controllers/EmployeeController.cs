using MVCAjaxCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAjaxCrud.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewAll()
        {
            return View(GetAllEmployees());
        }
        IEnumerable<Models.Employee> GetAllEmployees()
        {
            using (DBModel dB = new DBModel())
            {
                return dB.Employees.ToList<Employee>();
            }
        }
        public ActionResult AddOrEdit(int id=0)
        {
            Employee emp = new Employee();
            return View(emp);
        }
        [HttpPost]
        public ActionResult AddOrEdit()
        {
            return View();
        }
    }
}
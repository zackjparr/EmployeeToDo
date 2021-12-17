using JobMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JobMVC.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDAL db = new EmployeeDAL();
        public IActionResult Index()
        {
            List<Employee> employees = db.GetEmployees();
            return View(employees);
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Result(int id)
        {
            Employee e = db.GetEmployee(id);
            return View(e);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Employee e)
        {
            db.AddEmployee(e);
            return RedirectToAction("Index", "Employee"); 
        }

        public IActionResult Update(int id)
        {
            Employee e = db.GetEmployee(id);
            return View(e);
        }

        [HttpPost]
        public IActionResult Update(Employee e)
        {
            db.UpdateEmployee(e);
            return RedirectToAction("Index", "Employee");
        }

        public IActionResult Delete(int id)
        {
            Employee e = db.GetEmployee(id);
            return View(e);
        }

        [HttpPost]
        public IActionResult DeleteFromDB(int id)
        {
            db.DeleteEmployee(id);
            return RedirectToAction("index", "employee");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

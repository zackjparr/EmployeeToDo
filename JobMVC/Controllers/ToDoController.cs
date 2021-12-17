using JobMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobMVC.Controllers
{
    public class ToDoController : Controller
    {
        ToDoDAL db = new ToDoDAL();
        public IActionResult Index()
        {
            List<ToDo> todos = db.GetTodos();
            return View(todos);
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Result(int id)
        {
            ToDo t = db.GetTodo(id);
            return View(t);
        }

        public IActionResult Assign(int id)
        {
            ToDo t = db.GetTodo(id);
            return View(t);
        }
    }
}

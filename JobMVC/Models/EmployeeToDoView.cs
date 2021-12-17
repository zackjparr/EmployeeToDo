using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobMVC.Models
{
    public class EmployeeToDoView
    {
        public List<ToDo> ToDos { get; set; }
        public List<Employee> Employees { get; set; }
        public EmployeeToDoView()
        {
            ToDoDAL tdb = new ToDoDAL();
            EmployeeDAL edb = new EmployeeDAL();
            ToDos = tdb.GetTodos();
            Employees = edb.GetEmployees();
        }
    }
}

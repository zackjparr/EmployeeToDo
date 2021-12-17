using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobMVC.Models
{
    public class EmployeeDAL
    {
        public List<Employee> GetEmployees()
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                var sql = "select * from employees";
                connect.Open();
                List<Employee> employees = connect.Query<Employee>(sql).ToList();
                connect.Close();
                return employees;
            }
        }

        public Employee GetEmployee(int id)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
                {
                    string sql = $"select * from employees where ID = {id}";
                    connect.Open();
                    Employee e = connect.Query<Employee>(sql).First();
                    connect.Close();
                    return e;
                }
        }

        public void AddEmployee(Employee e)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "insert into employees " +
                    $"values(0, '{e.FullName}', {e.Hours}, '{e.Title}') ";
                connect.Open();
                connect.Query<Employee>(sql);
                connect.Close();
            }
        }

        public void UpdateEmployee(Employee e)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "update employees " + $"set fullName='{e.FullName}', hours={e.Hours}, title='{e.Title}' " +
                    $"where id={e.Id}"; ;
                connect.Open();
                connect.Query<Employee>(sql);
                connect.Close();
            }
        }

        public void DeleteEmployee(int id)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "delete from employees where id=" + id;
                connect.Open();
                connect.Query<Employee>(sql);
                connect.Close();
            }
        }
    }
}

using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobMVC.Models
{
    public class ToDoDAL
    {
        public List<ToDo> GetTodos()
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                var sql = "select * from todos";
                connect.Open();
                List<ToDo> todos = connect.Query<ToDo>(sql).ToList();
                connect.Close();
                return todos;
            }
        }

        public ToDo GetTodo(int id)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"select * from todos where ID = {id}";
                connect.Open();
                ToDo t = connect.Query<ToDo>(sql).First();
                connect.Close();
                return t;
            }
        }

        public void AssignToDo(ToDo t)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "update todos " + $"set assignedTo='{t.AssignedTo}' " +
                    $"where id={t.Id}"; ;
                connect.Open();
                connect.Query<ToDo>(sql);
                connect.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobMVC.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(25)]
        public string ToDoName { get; set; }
        [MaxLength(100)]
        public string ToDoDescription { get; set; }
        public int AssignedTo { get; set; }
        public int HoursNeeded { get; set; }
        public bool IsCompleted { get; set; }
        public Employee Employees { get; set; }
    }
}

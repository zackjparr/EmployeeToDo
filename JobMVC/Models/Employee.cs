using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobMVC.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string FullName { get; set; }
        public int Hours { get; set; }
        [MaxLength(40)]
        public string Title { get; set; }

        public List<ToDo> ToDos { get; set; }
    }
}

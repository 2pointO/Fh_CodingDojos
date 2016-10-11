using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class Todo
    {
        

        public string Description { get; set; }
        public bool Done { get; set; }

        public Todo(string description, bool done)
        {
            Description = description;
            Done = done;
        }
    }
}

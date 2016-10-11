using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.ViewModel
{
    public class ToDoVM
    {
        private Todo toDo;

        public string Description
        {
            get { return toDo.Description; }
            set { toDo.Description = value; }
        }

        public bool Done
        {
            get { return toDo.Done; }
            set { toDo.Done = value; }
        }

        public ToDoVM(string description, bool done)
        {
            toDo = new Todo(description, done);
        }

    }
    
}

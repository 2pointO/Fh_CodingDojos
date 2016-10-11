using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Commands;

namespace ToDoList.ViewModel
{
    class NewViewModel
    {

        private string newTaskDescription = "";

        public RelayCommand addBtnClickedCommand;

        public RelayCommand AddBtnClickedCommand
        {
            get { return addBtnClickedCommand; }
            set { addBtnClickedCommand = value; }
        }


        public string NewTaskDescription
        {
            get {return newTaskDescription; }
            set { newTaskDescription = value; }
        }

        private ObservableCollection<ToDoVM> toDoList = new ObservableCollection<ToDoVM>();

        public ObservableCollection<ToDoVM> ToDoList
        {
            get { return toDoList; }
            set { toDoList = value; }
        }

        public NewViewModel()
        {
             
         AddBtnClickedCommand = new RelayCommand(new Action(AddButtonClicked), new Func<bool>(CanExecute));
         LoadData();
        }

        private bool CanExecute()
        {
            return true;
        }

        private void AddButtonClicked()
        {
            ToDoList.Add(new ToDoVM(NewTaskDescription, false));
        }

        private void LoadData()
        {
            ToDoList.Add(new ToDoVM("Make it work", false));
            ToDoList.Add(new ToDoVM("Damnit", true));
        }

      

    }
}

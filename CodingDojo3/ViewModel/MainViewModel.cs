using CodingDojo3.Resources;
using CodingDojo4DataLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodingDojo3.ViewModel
{
    class MainViewModel
    {
        public RelayCommands addBtnClickedCommand;

        public RelayCommands AddBtnClickedCommand
        {
            get { return addBtnClickedCommand; }
            set { addBtnClickedCommand = value; }
        }

        public RelayCommands delBtnClickedCommand;

        public RelayCommands DelBtnClickedCommand
        {
            get { return delBtnClickedCommand; }
            set { delBtnClickedCommand = value; }
        }

        public RelayCommands editBtnClickedCommand;

        public RelayCommands EditBtnClickedCommand
        {
            get { return editBtnClickedCommand; }
            set { editBtnClickedCommand = value; }
        }

        private ObservableCollection<StockVM> stockList = new ObservableCollection<StockVM>();

        public ObservableCollection<StockVM> StockList
        {
            get { return StockList; }
            set { StockList = value; }
        }

        public MainViewModel()
        {

            //AddBtnClickedCommand = new RelayCommands(new Action(AddButtonClicked), new Func<bool>(CanExecute));
            LoadData();
        }

        private bool CanExecute()
        {
            return true;
        }

        private void AddButtonClicked()
        {
           // StockList.Add(new StockList(NewTaskDescription, false));
        }

        private void LoadData()
        {
           stockList.
        }

    }
}

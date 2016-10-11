using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CodingDojo3.Resources
{
    
        class RelayCommands : ICommand
        {


            private Action execute;
            private Func<bool> canExecute;

            public RelayCommands(Action execute, Func<bool> canExecute)
            {
                this.execute = execute;
                this.canExecute = canExecute;


            }
            // Command Manager register zum requery event
            event EventHandler ICommand.CanExecuteChanged
            {
                add
                {
                    CommandManager.RequerySuggested += value;
                }

                remove
                {
                    CommandManager.RequerySuggested -= value;
                }
            }

            public bool CanExecute(object parameter)
            {
                return canExecute();
            }

            public void Execute(object parameter)
            {
                execute();
            }


        }
    }


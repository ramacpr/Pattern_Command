using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandDesignPattern.Commands
{
    public class MyCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
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
        Action OnExecuteAction;
        Action OnUnExecuteAction; 

        public MyCommand(Action executeMethod, Action unExecuteMethod)
        {
            OnExecuteAction += executeMethod;
            OnUnExecuteAction += unExecuteMethod;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            OnExecuteAction();
        }

        public void UnExecute(object parameter)
        {
            OnUnExecuteAction();
        }
    }
}

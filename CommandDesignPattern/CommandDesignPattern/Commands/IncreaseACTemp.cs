using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CommandDesignPattern.Commands
{
    public class IncreaseACTemp 
    {
        public IncreaseACTemp() { }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show("Increase AC Temperature");
        }

        public void UnExecute()
        {
            throw new NotImplementedException();
        }
    }
}

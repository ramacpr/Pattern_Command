using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CommandDesignPattern.Commands
{
    public class DecreaseACTemp 
    {
        public DecreaseACTemp() { }

        public void Execute(object parameter)
        {
            MessageBox.Show("Decreased AC Temperature");
        }

        public void UnExecute()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CommandDesignPattern.Receivers
{
    public class Fan : IReceiver
    {
        public Fan() { }

        public void ActionOff()
        {
            MessageBox.Show("Fan Off");
        }

        public void ActionOn()
        {
            MessageBox.Show("Fan On");
        }
    }
}

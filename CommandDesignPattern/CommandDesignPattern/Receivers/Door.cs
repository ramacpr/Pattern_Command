using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CommandDesignPattern.Receivers
{
    public class Door : IReceiver
    {
        public Door() { }

        public void ActionOff()
        {
            MessageBox.Show("Door Closed");
        }

        public void ActionOn()
        {
            MessageBox.Show("Door Open");
        }
    }
}

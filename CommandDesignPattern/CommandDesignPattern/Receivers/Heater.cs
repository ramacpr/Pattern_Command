using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CommandDesignPattern.Receivers
{
    public class Heater : IReceiver
    {
        public Heater() { }

        public void ActionOff()
        {
            MessageBox.Show("Heater Off");
        }

        public void ActionOn()
        {
            MessageBox.Show("Heater On");
        }
    }
}

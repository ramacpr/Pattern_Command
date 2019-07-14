using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CommandDesignPattern.Receivers
{
    public class Lights : IReceiver
    {
        public Lights() { }

        public void ActionOff()
        {
            MessageBox.Show("Lights Off");
        }

        public void ActionOn()
        {
            MessageBox.Show("Lights On");
        }
    }
}

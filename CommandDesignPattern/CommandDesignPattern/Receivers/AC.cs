using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CommandDesignPattern.Receivers
{
    public class AC : IReceiver
    {
        public AC() { }

        public void ActionOff()
        {
            MessageBox.Show("Decreased AC");
        }

        public void ActionOn()
        {
            MessageBox.Show("Increased AC");
        }
    }
}

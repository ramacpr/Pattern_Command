using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Receivers
{
    public interface IReceiver
    {
        void ActionOn();
        void ActionOff();
    }
}

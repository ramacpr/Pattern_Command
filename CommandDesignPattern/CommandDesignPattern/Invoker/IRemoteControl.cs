using CommandDesignPattern.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandDesignPattern.Invoker
{
    public interface IRemoteControl
    {
        void SetButton1Command(MyCommand myCommand);
        void SetButton2Command(MyCommand myCommand);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommandDesignPattern.Commands;

namespace CommandDesignPattern.Invoker
{
    public class RemoteControl_2Button : IRemoteControl
    {
        private ICommand _button1Cmd;
        public ICommand Button1Cmd { get => _button1Cmd; set => _button1Cmd = value; }
        
        private ICommand _button2Cmd;
        public ICommand Button2Cmd { get => _button2Cmd; set => _button2Cmd = value; }

        public RemoteControl_2Button() { }
        public void SetButton1Command(ICommand myCommand) {
            Button1Cmd = myCommand;
        }

        public void SetButton2Command(ICommand myCommand) {
            Button2Cmd = myCommand;
        }

        public void ExecuteButton1()
        {
            if (Button1Cmd == null)
                return;
            Button1Cmd.Execute(null);
        }

        public void ExecuteButton2()
        {
            if (Button2Cmd == null)
                return;
            Button2Cmd.Execute(null);
        }
    }
}

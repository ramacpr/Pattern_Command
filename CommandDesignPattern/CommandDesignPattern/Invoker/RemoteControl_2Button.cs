using CommandDesignPattern.Commands;
using CommandDesignPattern.Globals;
using CommandDesignPattern.Receivers;
using System.Collections.Generic;
using System.ComponentModel;

namespace CommandDesignPattern.Invoker
{
    public class RemoteControl_2Button : IRemoteControl, INotifyPropertyChanged 
    {
        public RemoteControl_2Button()
        {
            MyCommandList = new List<string>();
            MyCommandList.Add("None");
            MyCommandList.Add(CustomCommandStrings.LightOnCmd);
            MyCommandList.Add(CustomCommandStrings.LightsOffCmd);
            MyCommandList.Add(CustomCommandStrings.DoorOpenCmd);
            MyCommandList.Add(CustomCommandStrings.DoorClosedCmd);
            MyCommandList.Add(CustomCommandStrings.FanOnCmd);
            MyCommandList.Add(CustomCommandStrings.FanOffCmd);
            MyCommandList.Add(CustomCommandStrings.HeaterOnCmd);
            MyCommandList.Add(CustomCommandStrings.HeaterOffCmd);
            MyCommandList.Add(CustomCommandStrings.IncreaseACCmd);
            MyCommandList.Add(CustomCommandStrings.DecreaseACCmd);

            SelectedCommandButton1 = MyCommandList[0];
            SelectedCommandButton2 = MyCommandList[0];
        }

        private List<string> _commandList;
        public List<string> MyCommandList { get => _commandList; set => _commandList = value; }

        private string _selectedCommandButton1; 
        public string SelectedCommandButton1
        {
            get => _selectedCommandButton1;
            set { _selectedCommandButton1 = value; OnSelectionChanged(value, 1); OnPropertyChanged("SelectedCommandButton1"); }
        }

        private string _selectedCommandButton2;
        public string SelectedCommandButton2
        {
            get => _selectedCommandButton2;
            set { _selectedCommandButton2 = value; OnSelectionChanged(value, 2); OnPropertyChanged("SelectedCommandButton2"); }
        }

        private MyCommand _button1Cmd;
        public MyCommand Button1Cmd
        {
            get => _button1Cmd;
            set
            {
                _button1Cmd = value;
                OnPropertyChanged("Button1Cmd");
            }
        }
        
        private MyCommand _button2Cmd;
        public MyCommand Button2Cmd
        {
            get => _button2Cmd;
            set
            {
                _button2Cmd = value;
                OnPropertyChanged("Button2Cmd");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        
        public void SetButton1Command(MyCommand myCommand) {
            Button1Cmd = myCommand;
        }

        public void SetButton2Command(MyCommand myCommand) {
            Button2Cmd = myCommand;
        }

        private MyCommand GetCommand(string cmdString)
        {
            bool isOffCmd = false;
            MyCommand cmd = null;
            IReceiver receiverObj = null;
            switch (cmdString)
            {
                case CustomCommandStrings.IncreaseACCmd:
                    receiverObj = new AC() as IReceiver;
                    break;
                case CustomCommandStrings.DecreaseACCmd:
                    isOffCmd = true;
                    receiverObj = new AC() as IReceiver;
                    break;

                case CustomCommandStrings.DoorClosedCmd:
                    isOffCmd = true;
                    receiverObj = new Door() as IReceiver;
                    break;
                case CustomCommandStrings.DoorOpenCmd:
                    receiverObj = new Door() as IReceiver;
                    break;

                case CustomCommandStrings.FanOffCmd:
                    isOffCmd = true;
                    receiverObj = new Fan() as IReceiver;
                    break;
                case CustomCommandStrings.FanOnCmd:
                    receiverObj = new Fan() as IReceiver;
                    break;

                case CustomCommandStrings.HeaterOffCmd:
                    isOffCmd = true;
                    receiverObj = new Heater() as IReceiver;
                    break;
                case CustomCommandStrings.HeaterOnCmd:
                    receiverObj = new Heater() as IReceiver;
                    break;

                case CustomCommandStrings.LightOnCmd:
                    receiverObj = new Lights() as IReceiver;
                    break;
                case CustomCommandStrings.LightsOffCmd:
                    isOffCmd = true;
                    receiverObj = new Lights() as IReceiver;
                    break;
            }

            if (receiverObj != default(IReceiver))
            {
                if (isOffCmd is true)
                    cmd = new MyCommand(new System.Action(receiverObj.ActionOff), new System.Action(receiverObj.ActionOn));
                else
                    cmd = new MyCommand(new System.Action(receiverObj.ActionOn), new System.Action(receiverObj.ActionOff));
            }
            return cmd;
        }

        private void OnSelectionChanged(string selection, int buttonNumber)
        {
            switch(buttonNumber)
            {
                case 1:
                    SetButton1Command(GetCommand(selection));
                    break;
                case 2:
                    SetButton2Command(GetCommand(selection));
                    break;
            }
        }
    }
}

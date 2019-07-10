using CommandDesignPattern.Commands;
using System.Collections.Generic;
using System.ComponentModel;

namespace CommandDesignPattern.Invoker
{
    public class RemoteControl_2Button : IRemoteControl, INotifyPropertyChanged 
    {
        private List<string> _commandList;
        public List<string> MyCommandList { get => _commandList; set => _commandList = value; }

        private string _selectedCommandButton1; 
        public string SelectedCommandButton1
        {
            get => _selectedCommandButton1;
            set { _selectedCommandButton1 = value; OnPropertyChanged("SelectedCommandButton1"); }
        }

        private string _selectedCommandButton2;
        public string SelectedCommandButton2
        {
            get => _selectedCommandButton2;
            set { _selectedCommandButton2 = value; OnPropertyChanged("SelectedCommandButton2"); }
        }

        private MyCommand _button1Cmd;
        public MyCommand Button1Cmd { get => _button1Cmd; set => _button1Cmd = value; }
        
        private MyCommand _button2Cmd;
        public MyCommand Button2Cmd { get => _button2Cmd; set => _button2Cmd = value; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public RemoteControl_2Button()
        {
            MyCommandList = new List<string>();
            MyCommandList.Add("None");
            MyCommandList.Add("Lights On");
            MyCommandList.Add("Lights Off");
            MyCommandList.Add("Door Open");
            MyCommandList.Add("Door Close");
            MyCommandList.Add("Fan On");
            MyCommandList.Add("Fan Off");
            MyCommandList.Add("Heater On");
            MyCommandList.Add("Heater Off");
            MyCommandList.Add("Increase AC");
            MyCommandList.Add("Decrease AC");

            SelectedCommandButton1 = MyCommandList[0];
            SelectedCommandButton2 = MyCommandList[0];
        }
        public void SetButton1Command(MyCommand myCommand) {
            Button1Cmd = myCommand;
        }

        public void SetButton2Command(MyCommand myCommand) {
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

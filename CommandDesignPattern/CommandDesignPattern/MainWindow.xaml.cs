using CommandDesignPattern.Commands;
using CommandDesignPattern.Invoker;
using CommandDesignPattern.Receivers;
using System.Windows;

namespace CommandDesignPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new RemoteControl_2Button();   
        }

        /*private void B1_Configure_Click(object sender, RoutedEventArgs e)
        {
            AllCommands selectedCmd = AllCommands.None;
            ConfigureBtnView selectCmdWnd = new ConfigureBtnView();
            selectCmdWnd.ShowDialog();
            selectedCmd = selectCmdWnd.SelectedCommand;

            //
        }

        private void B2_Configure_Click(object sender, RoutedEventArgs e)
        {
            AllCommands selectedCmd = AllCommands.None;
            ConfigureBtnView selectCmdWnd = new ConfigureBtnView();
            if (selectCmdWnd.ShowDialog() == null)
                return;
            selectedCmd = selectCmdWnd.SelectedCommand;

            //(this.DataContext as RemoteControl_2Button).SetButton2Command(GetCommand(selectedCmd));
        }*/

        private MyCommand GetCommand(string cmdString)
        {
            MyCommand cmd = null;
            IReceiver receiverObj = null; 
            switch(cmdString)
            {
                case "Increase AC":
                case "Decrease AC":
                    receiverObj = new AC() as IReceiver;
                    break;
                case "Door Close":
                case "Door Open":
                    receiverObj = new Door() as IReceiver;
                    break;
                case "Fan Off":            
                case "Fan On":
                    receiverObj = new Fan() as IReceiver;
                    break;
                case "Heater Off":
                case "Heater On":
                    receiverObj = new Heater() as IReceiver;
                    break;
                case "Light Off":
                case "Light On":
                    receiverObj = new Lights() as IReceiver;
                    break;                           
            }

            if (receiverObj != default(IReceiver))
                cmd = new MyCommand(new System.Action(receiverObj.ActionOn), new System.Action(receiverObj.ActionOff));       
            return cmd;
        }

        /*
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as RemoteControl_2Button).ExecuteButton1();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as RemoteControl_2Button).ExecuteButton2();
        }
        */

        private void B1Setting_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string selected_cmd = (this.DataContext as RemoteControl_2Button).SelectedCommandButton1;
            (this.DataContext as RemoteControl_2Button).SetButton1Command(GetCommand(selected_cmd));
        }

        private void B2Setting_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string selected_cmd = (this.DataContext as RemoteControl_2Button).SelectedCommandButton2;
            (this.DataContext as RemoteControl_2Button).SetButton1Command(GetCommand(selected_cmd));
        }
    }
}

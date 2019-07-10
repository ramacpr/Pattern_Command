using CommandDesignPattern.Commands;
using CommandDesignPattern.Invoker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        private void B1_Configure_Click(object sender, RoutedEventArgs e)
        {
            AllCommands selectedCmd = AllCommands.None;
            ConfigureBtnView selectCmdWnd = new ConfigureBtnView();
            selectCmdWnd.ShowDialog();
            selectedCmd = selectCmdWnd.SelectedCommand;

            (this.DataContext as RemoteControl_2Button).SetButton1Command(GetCommand(selectedCmd));
        }

        private void B2_Configure_Click(object sender, RoutedEventArgs e)
        {
            AllCommands selectedCmd = AllCommands.None;
            ConfigureBtnView selectCmdWnd = new ConfigureBtnView();
            selectCmdWnd.ShowDialog();
            selectedCmd = selectCmdWnd.SelectedCommand;

            (this.DataContext as RemoteControl_2Button).SetButton2Command(GetCommand(selectedCmd));
        }

        private ICommand GetCommand(AllCommands cmdCode)
        {
            ICommand cmd = null;
            switch(cmdCode)
            {
                case AllCommands.ACDown:
                    cmd = new DecreaseACTemp();
                    break;
                case AllCommands.ACUp:
                    cmd = new IncreaseACTemp();
                    break;
                case AllCommands.DoorClose:
                    cmd = new DoorClose();
                    break;
                case AllCommands.DoorOpen:
                    cmd = new DoorOpen();
                    break;
                case AllCommands.FanOff:
                    cmd = new FanOff();
                    break;
                case AllCommands.FanOn:
                    cmd = new FanOn();
                    break;
                case AllCommands.HeaterOff:
                    cmd = new HeaterOff();
                    break;
                case AllCommands.HeaterOn:
                    cmd = new HeaterOn();
                    break;
                case AllCommands.LightOff:
                    cmd = new LightsOff();
                    break;
                case AllCommands.LightOn:
                    cmd = new LightsOn();
                    break;                  
            }
            return cmd;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as RemoteControl_2Button).ExecuteButton1();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as RemoteControl_2Button).ExecuteButton2();
        }
    }
}

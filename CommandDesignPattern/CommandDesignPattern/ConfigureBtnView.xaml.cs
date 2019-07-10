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
using System.Windows.Shapes;

namespace CommandDesignPattern
{
    public enum AllCommands
    {
        None = 0,
        LightOn, 
        LightOff, 
        FanOn, 
        FanOff,
        HeaterOn, 
        HeaterOff, 
        DoorOpen, 
        DoorClose,
        ACUp,
        ACDown
    };

    /// <summary>
    /// Interaction logic for ConfigureBtnView.xaml
    /// </summary>
    public partial class ConfigureBtnView : Window
    {
        public AllCommands SelectedCommand;
        public ConfigureBtnView()
        {
            InitializeComponent();
            SelectedCommand = AllCommands.None;
        }

        private void R1_Checked(object sender, RoutedEventArgs e)        {
            SelectedCommand = AllCommands.LightOn;
            this.Close();
        }

        private void R2_Checked(object sender, RoutedEventArgs e)        {
            SelectedCommand = AllCommands.LightOff;
            this.Close();
        }

        private void R3_Checked(object sender, RoutedEventArgs e)        {
            SelectedCommand = AllCommands.FanOn;
            this.Close();
        }

        private void R4_Checked(object sender, RoutedEventArgs e)        {
            SelectedCommand = AllCommands.FanOff;
            this.Close();
        }

        private void R5_Checked(object sender, RoutedEventArgs e)        {
            SelectedCommand = AllCommands.HeaterOn;
            this.Close();
        }

        private void R6_Checked(object sender, RoutedEventArgs e)        {
            SelectedCommand = AllCommands.HeaterOff;
            this.Close();
        }

        private void R7_Checked(object sender, RoutedEventArgs e)        {
            SelectedCommand = AllCommands.DoorOpen;
            this.Close();
        }

        private void R8_Checked(object sender, RoutedEventArgs e)
        {
            SelectedCommand = AllCommands.DoorClose;
            this.Close();
        }

        private void R9_Checked(object sender, RoutedEventArgs e)
        {
            SelectedCommand = AllCommands.ACUp;
            this.Close();
        }

        private void R10_Checked(object sender, RoutedEventArgs e)
        {
            SelectedCommand = AllCommands.ACDown;
            this.Close();
        }
    }
}

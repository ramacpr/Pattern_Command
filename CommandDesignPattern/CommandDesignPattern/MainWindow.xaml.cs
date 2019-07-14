using CommandDesignPattern.Commands;
using CommandDesignPattern.Globals;
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

    }
}

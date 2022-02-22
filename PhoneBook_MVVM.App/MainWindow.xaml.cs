using System.Windows;
using System.Windows.Input;
using PhoneBook_MVVM.ViewModel;

namespace PhoneBook_MVVM.App
{
    public partial class MainWindow : Window
    {
        private Controller controller;
        public MainWindow()
        {
            InitializeComponent();

            controller = DataContext as Controller;
        }

        private void Command_AddPerson_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            controller.AddPerson(e.Parameter);
        }

        private void Command_DelPerson_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            controller.DelPerson(e.Parameter);
        }
    }
}
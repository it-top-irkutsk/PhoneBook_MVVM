using System.Windows;
using System.Windows.Input;
using PhoneBook_MVVM.ViewModel;
using PhoneBook_MVVM.Views;

namespace PhoneBook_MVVM.App
{
    public partial class MainWindow : Window
    {
        private readonly Controller _controller;
        private readonly ListOfPerson _listOfPerson;
        public MainWindow()
        {
            InitializeComponent();

            _controller = DataContext as Controller;

            _listOfPerson = new ListOfPerson { Persons = _controller?.Persons };
            _controller!.SelectedPerson = _listOfPerson.Person;
            ListOfPersons.Children.Add(_listOfPerson);
        }

        private void Command_AddPerson_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            _controller.AddPerson(e.Parameter);
        }

        private void Command_DelPerson_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            _controller.DelPerson(e.Parameter);
        }
    }
}
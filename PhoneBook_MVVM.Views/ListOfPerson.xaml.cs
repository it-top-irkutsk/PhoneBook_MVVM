using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using PhoneBook_MVVM.Model;

namespace PhoneBook_MVVM.Views
{
    public partial class ListOfPerson : UserControl
    {
        public ObservableCollection<Person> Persons { get; set; }

        public Person Person
        {
            get => (Person)GetValue(PersonProperty);
            set => SetValue(PersonProperty, value);
        }
        
        public static readonly DependencyProperty PersonProperty = DependencyProperty.Register(
            "Person", 
            typeof(Person), 
            typeof(ListOfPerson), 
            new PropertyMetadata(new Person())
            );
        
        public ListOfPerson()
        {
            InitializeComponent();
            
            DataContext = this;
        }

        private void ListPersons_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Person = (Person)ListPersons.SelectedItem;
        }
    }
}
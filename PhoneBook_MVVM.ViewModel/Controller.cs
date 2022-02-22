using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using PhoneBook_MVVM.Model;
using PhoneBook_MVVM.ViewModel.Annotations;

namespace PhoneBook_MVVM.ViewModel
{
    public class Controller : INotifyPropertyChanged
    {
        private Person _person;
        public Person SelectedPerson
        {
            get => _person;
            set
            {
                _person = value;
                OnPropertyChanged(nameof(SelectedPerson));
            }
        }
        
        public ObservableCollection<Person> Persons { get; set; }

        public Controller()
        {
            Persons = new ObservableCollection<Person>
            {
                new()
                {
                    LastName = "Starinin",
                    FirstName = "Andrey",
                    Phone = "+79042144491",
                    Email = "starininandrey@gmail.com",
                    Address = "Voronezh"
                }
            };
        }
        
        public void AddPerson(object obj)
        {
            var person = obj as Person;
            Persons.Add(person);
        }
        public void DelPerson(object obj)
        {
            var person = obj as Person;
            Persons.Remove(person);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
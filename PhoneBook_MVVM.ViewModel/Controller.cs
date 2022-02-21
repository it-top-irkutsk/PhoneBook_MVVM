using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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

        private Commands _command;
        public Commands Command
        {
            get => _command ??= new Commands(
                o =>
                {
                    var person = o as Person;
                    Persons.Add(person);
                });
        }

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

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
using System.Windows.Input;

namespace PhoneBook_MVVM.ViewModel
{
    public class Commands
    {
        private static readonly RoutedUICommand _add;
        private static readonly RoutedUICommand _del;

        static Commands()
        {
            var inputs_add = new InputGestureCollection();
            inputs_add.Add(new KeyGesture(Key.Add, ModifierKeys.Control, "Ctrl + '+'"));
            _add = new RoutedUICommand("Добавить", "AddPerson", typeof(Commands), inputs_add);
            
            var inputs_del = new InputGestureCollection();
            inputs_del.Add(new KeyGesture(Key.Subtract, ModifierKeys.Control, "Ctrl + '-'"));
            _del = new RoutedUICommand("Удалить", "DelPerson", typeof(Commands), inputs_del);
        }

        public static RoutedUICommand AddPerson => _add;
        public static RoutedUICommand DelPerson => _del;
    }
}
using System;
using System.Globalization;
using System.Windows.Data;
using PhoneBook_MVVM.Model;

namespace PhoneBook_MVVM.ViewModel
{
    public class ConvertPersonFromStrings : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return new Person
            {
                LastName = values[0].ToString(),
                FirstName = values[1].ToString(),
                Phone = values[2].ToString(),
                Email = values[3].ToString(),
                Address = values[4].ToString()
            };
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
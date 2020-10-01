using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace CustomTextBox.Converters
{
    internal class TextFieldHeightConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length != 2)
                return 0;

            var textField = values[0] as TextField;
            var containerGrid = values[1] as Grid;
            var result = containerGrid.ActualHeight;

            textField.Height = double.NaN;
            containerGrid.Height = double.NaN;

            return result;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Globalization;
using Xamarin.Forms;

namespace CrossApp
{
    public class DoubleToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
                              object parameter, CultureInfo culture)
        {
            double number = (double)value;
            if (number == 0)
            {
                return "";
            }

            return number.ToString();
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            double number = 0;
            Double.TryParse((string)value, out number);
            return number;
        }
    }

    public class DoubleRoundingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
                              object parameter, CultureInfo culture)
        {
            return Round((double)value, parameter);
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            return Round((double)value, parameter);
        }

        double Round(double number, object parameter)
        {
            double precision = 1;
            if (parameter != null)
            {
                precision = Double.Parse((string)parameter);
            }
            return precision * Math.Round(number / precision);
        }
    }

}

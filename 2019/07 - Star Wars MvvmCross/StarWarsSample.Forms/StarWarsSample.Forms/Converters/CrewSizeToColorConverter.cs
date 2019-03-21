using System;
using System.Globalization;
using Xamarin.Forms;

namespace StarWarsSample.Forms.UI.Converters
{
    public class CrewSizeToColorConverter : IValueConverter
    {
        private const int MinimunSize = 50;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int.TryParse((string)value, out int crew);
            return crew >= MinimunSize ? Color.Green: Color.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

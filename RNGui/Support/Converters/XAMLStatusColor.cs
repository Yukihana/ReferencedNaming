using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace CSX.Wpf.Y2022.RNGui.Support.Converters
{
    internal class XAMLStatusColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            byte index = Math.Clamp((byte)value, (byte)0, (byte)3);
            Color color = index switch
            {
                1 => Colors.LimeGreen,
                3 => Colors.Maroon,
                _ => Colors.Gray,
            };
            return new SolidColorBrush(color);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotImplementedException();
    }
}
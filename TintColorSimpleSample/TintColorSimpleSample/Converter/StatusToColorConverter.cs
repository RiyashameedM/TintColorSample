using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TintColorSimpleSample.Converter
{
    public class StatusToColorConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return (int)value>0 ?
                    Colors.Yellow :
                    Colors.Black;
            }
            catch (Exception ex)
            {
                return Colors.Black;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //throw new NotImplementedException();
            return null;
        }

        #endregion
    }

}

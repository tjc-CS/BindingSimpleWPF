
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp4
{
    class IntegerToStringConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object paramater, CultureInfo culture)
        {
           
            if((int)value > 10)
            {
                return ">10";
            }
            return "<10";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}

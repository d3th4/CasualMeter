﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Tera.DamageMeter;

namespace CasualMeter.Common.Converters
{
    public class LongToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int) value = (long)(int)value;

            if (value != null && !(value is long))
                throw new ArgumentException($"Invalid arguments passed to {nameof(LongToStringConverter)}.");

            var helper = FormatHelpers.Pretty;
            return helper.FormatValue((long?) value ?? 0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}

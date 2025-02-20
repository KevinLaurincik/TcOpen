﻿using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using System.Windows.Markup;

namespace TcoCore
{
    public class DialogTypeToColorConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var b = (eDialogType)Enum.Parse(typeof(eDialogType), value.ToString());

            switch (b)
            {
                case eDialogType.Undefined:
                    return Wpf.TcoColors.Secondary;
                case eDialogType.Info:
                    return Wpf.TcoColors.Secondary;
                case eDialogType.Question:
                    return Wpf.TcoColors.Primary;
                case eDialogType.Warning:
                    return Wpf.TcoColors.Alert;
                case eDialogType.Error:
                    return Wpf.TcoColors.Alert;
                default:
                    return Wpf.TcoColors.Secondary;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}

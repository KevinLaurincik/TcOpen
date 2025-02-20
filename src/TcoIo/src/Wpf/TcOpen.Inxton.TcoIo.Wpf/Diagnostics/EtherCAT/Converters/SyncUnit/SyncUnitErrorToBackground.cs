﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;

namespace TcoIo.Converters
{
    public class SyncUnitErrorToBackground : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
            {
                return TcoCore.Wpf.TcoColors.Error;
            }
            else
            {
                ResourceDictionary ColorResorce = new ResourceDictionary();
                ColorResorce.Source = new Uri("/TcOpen.Inxton.TcoIo.Wpf;component/diagnostics/ethercat/colors/colors.xaml", UriKind.RelativeOrAbsolute);
                return new SolidColorBrush((Color)ColorResorce["InxtonGrayLightColor"]);
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

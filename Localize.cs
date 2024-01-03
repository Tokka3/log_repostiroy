using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Logi
{
	// Token: 0x0200000E RID: 14
	public class Localize : IValueConverter
	{
		// Token: 0x06000084 RID: 132 RVA: 0x0000C6C8 File Offset: 0x0000A8C8
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value != null && value is string)
			{
				App app = Application.Current as App;
				STRING key;
				Enum.TryParse<STRING>((string)value, out key);
				return Utils.WithBrand(Strings.Get(key), app.Brand);
			}
			return value;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000C70C File Offset: 0x0000A90C
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return null;
		}
	}
}

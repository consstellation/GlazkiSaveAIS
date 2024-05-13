using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace GlazkiSave.Classes
{
    class ConvertImage: IValueConverter
    {
        public object Convert(object value, Type targetType, object parametr, CultureInfo culture)
        {
            try
            {
                BitmapImage bitmapImage = new BitmapImage();

                if (value is null)
                    throw new NotImplementedException();



                using (MemoryStream memory = new MemoryStream())
                {
                    bitmapImage.BeginInit();
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapImage.UriSource = new Uri(value.ToString(), UriKind.Relative);
                    bitmapImage.EndInit();

                }
                return bitmapImage;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

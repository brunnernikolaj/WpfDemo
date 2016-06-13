using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DesktopAppLib.Classes
{
    public static class WpfColors
    {
        public static List<SolidColorBrush> Colors = new List<SolidColorBrush>();

        static WpfColors()
        {
            foreach (PropertyInfo pInfo in typeof(Brushes).GetProperties())
            {
                var color = pInfo.GetValue(typeof(Brushes)) as SolidColorBrush;
                Colors.Add(color);
            }
        }
    }
}

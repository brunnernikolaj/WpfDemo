using DesktopAppMvvm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DesktopAppMvvm.EditWindowControls.DataContexts
{
    public class EditColorDataContext : ModelBase
    {
        private SolidColorBrush _Color;
        public SolidColorBrush Color
        {
            get { return _Color; }
            set { _Color = value; NotifyPropertyChanged("Color");}
        }

        private string _PropertyName;
        public string PropertyName
        {
            get { return _PropertyName; }
            set { _PropertyName = value; NotifyPropertyChanged("PropertyName"); }
        }

        private string _ImageName;
        public string ImageName
        {
            get { return _ImageName; }
            set { _ImageName = value; NotifyPropertyChanged("ImageName"); }
        }
    }
}

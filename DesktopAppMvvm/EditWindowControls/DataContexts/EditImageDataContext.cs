using DesktopAppMvvm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DesktopAppMvvm.EditWindowControls.DataContexts
{
    public class EditImageDataContext : ModelBase
    {
        private ImageSource _Image;
        public ImageSource Image
        {
            get { return _Image; }
            set { _Image = value; NotifyPropertyChanged("Image"); }
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

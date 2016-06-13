using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace DesktopAppMvvm.Model
{
    class MainWindowModel : ModelBase, DesktopAppMvvm.Model.IModel
    {
        private ImageSource _BackgroundImage;
        public ImageSource BackgroundImage
        {
            get { return _BackgroundImage; }
            set { _BackgroundImage = value; NotifyPropertyChanged("BackgroundImage"); }
        }

        private int _ModulesOpenCount;
        public int ModulesOpenCount
        {
            get { return _ModulesOpenCount; }
            set { _ModulesOpenCount = value; NotifyPropertyChanged("ModulesOpenCount"); }
        }

        private ContextMenu _RightClickMenu;
        public ContextMenu RightClickMenu
        {
            get { return _RightClickMenu; }
            set { _RightClickMenu = value; NotifyPropertyChanged("RightClickMenu"); }
        }

        public List<PropertyInfo> GetProperties()
        {
            return this.GetType().GetProperties().ToList();
        }

        public MainWindowModel()
        {
            
        }






    }
}

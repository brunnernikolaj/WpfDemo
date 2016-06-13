using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using DesktopAppMvvm.ViewModel;
using DesktopAppMvvm.View;
using System.Windows.Media;

namespace DesktopAppMvvm.Model
{
    class HarddiskModuleModel : ModelBase, IModel
    {
        public HarddiskModuleModel()
        {
            
        }

        private TimeSpan _RefreshSpeed;
        public TimeSpan RefreshSpeed
        {
            get { return _RefreshSpeed; }
            set { _RefreshSpeed = value; NotifyPropertyChanged("RefreshSpeed"); }
        }

        private long _HarddiskUsage;
        public long HarddiskUsage
        {
            get { return _HarddiskUsage; }
            set { _HarddiskUsage = value; NotifyPropertyChanged("HarddiskUsage"); }
        }

        private SolidColorBrush _BackgroundColor;
        public SolidColorBrush BackgroundColor
        {
            get { return _BackgroundColor; }
            set { _BackgroundColor = value; NotifyPropertyChanged("BackgroundColor"); }
        }

        public void Unload()
        {

        }

        public List<System.Reflection.PropertyInfo> GetProperties()
        {
            return this.GetType().GetProperties().ToList();
        }
    }
}

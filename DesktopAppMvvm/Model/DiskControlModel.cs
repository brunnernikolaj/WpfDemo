using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DesktopAppLib;
using System.Windows.Media;

namespace DesktopAppMvvm.Model
{
    class DiskControlModel : ModelBase
    {
        private double _UsageRectWidth;
        public double UsageRectWidth
        {
            get { return _UsageRectWidth; }
            set { _UsageRectWidth = value; NotifyPropertyChanged("UsageRectWidth"); }
        }

        private SolidColorBrush _UsageRectColor;
        public SolidColorBrush UsageRectColor
        {
            get { return _UsageRectColor; }
            set { _UsageRectColor = value; NotifyPropertyChanged("UsageRectColor"); }
        }

        private string _UsageString;
        public string UsageString
        {
            get { return _UsageString; }
            set { _UsageString = value; NotifyPropertyChanged("UsageString"); }
        }

        private string _HarddiskName;
        public string HarddiskName
        {
            get { return _HarddiskName; }
            set { _HarddiskName = value; NotifyPropertyChanged("HarddiskName"); }
        }

        private TimeSpan _RefreshSpeed;
        public TimeSpan RefreshSpeed
        {
            get { return _RefreshSpeed; }
            set { _RefreshSpeed = value; NotifyPropertyChanged("RefreshSpeed"); }
        }

        public DiskControlModel(DriveInfo dInfo)
        {
            UsageRectWidth = dInfo.ToPercentDouble() * 3;
            UsageString = dInfo.ToUsageString();
            UsageRectColor = Brushes.Orange;
            HarddiskName = dInfo.Name;
        }
    }
}
